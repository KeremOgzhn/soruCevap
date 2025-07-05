using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace soruCevapPro
{
    public partial class SinavStart : Form
    {
        public SinavStart()
        {
            InitializeComponent();
        }

        int soruSayisi = 0;
        DataTable tablo;
        int sayac;
        int dogru = 0, yanlis = 0;
        double puan = 0;
        int kisiID; 
        private void SinavStart_Load(object sender, EventArgs e)
        {
            sayac = 0;
            lblAdSoyad.Text = SinavYap.adSoyad.ToString();
            kisiID = SinavYap.ID; 

            SqlCommand komut = new SqlCommand("select * from sorular ", Baglanti.baglan());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            soruSayisi = tablo.Rows.Count;
            getir();


        }
        public void getir()
        {
            if (sayac < soruSayisi)
            {
                lblSoru.Text = sayac + 1 + ". Soru : " + tablo.Rows[sayac]["soruMetni"].ToString();
                rbA.Text = "A) " + tablo.Rows[sayac]["aSec"].ToString();
                rbB.Text = "B) " + tablo.Rows[sayac]["bSec"].ToString();
                rbC.Text = "C) " + tablo.Rows[sayac]["cSec"].ToString();
                rbD.Text = "D) " + tablo.Rows[sayac]["dSec"].ToString();
            }
            else
                MessageBox.Show("Listede kayıtlı soru yok !");

        }

        void kaydet()
        {
            SqlCommand komut = new SqlCommand("insert into sinavlar ( kisiID, tarih,    puan  ) values ( @p1, @p2, @p3 )  ", Baglanti.baglan());
            if (Baglanti.baglan().State != ConnectionState.Open)
            {
                Baglanti.baglan().Open();
            }
            komut.Parameters.AddWithValue("@p1", kisiID   );
            komut.Parameters.AddWithValue("@p2", DateTime.Now );
            komut.Parameters.AddWithValue("@p3", puan );

            komut.ExecuteNonQuery();
            MessageBox.Show("Sınav sonucu kayededildi ", "sinav kayıt işlemi");

        }

        public void startla()
        {

            if (rbA.Checked == false && rbB.Checked == false && rbC.Checked == false && rbD.Checked == false)
            {
                MessageBox.Show("Lütfen Doğru Cevabı İşaretleyiniz ", "Hatalı işlem ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (sayac == soruSayisi)
                {
                    puan = ((double)dogru / ((double)dogru + yanlis)) * 100;
                    MessageBox.Show("Sinav Tamamlandi ", " Sonuç ");
                    MessageBox.Show("Dogru Sayisi : " + dogru + " Yanliş Sayisi : " + yanlis + " Puaniniz : " + puan);
                    sayac = 0;
                    btnOnay.Enabled = false;
                    lblPuan.Text += puan.ToString();

                    kaydet(); 

                }
                else
                {

                    string dc = tablo.Rows[sayac]["dogruCevap"].ToString();

                    if (dc == "A" && rbA.Checked || dc == "B" && rbB.Checked || dc == "C" && rbC.Checked || dc == "D" && rbD.Checked)
                    {

                        dogru++;
                        // MessageBox.Show("bildin");

                    }
                    else
                        yanlis++;

                    sayac++;
                    if (sayac < soruSayisi)
                    {
                        lblSoru.Text = sayac + 1 + ". Soru : " + tablo.Rows[sayac]["soruMetni"].ToString();
                        rbA.Text = "A) " + tablo.Rows[sayac]["aSec"].ToString();
                        rbB.Text = "B) " + tablo.Rows[sayac]["bSec"].ToString();
                        rbC.Text = "C) " + tablo.Rows[sayac]["cSec"].ToString();
                        rbD.Text = "D) " + tablo.Rows[sayac]["dSec"].ToString();

                    }
                    else
                    {
                        btnOnay.Text = "Bitir... ".ToString();
                        btnOnay.ForeColor = Color.Red;
                        
                    }



                }

            }



        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            startla();

            // MessageBox.Show(sayac + " sayac: ");

        }
    }
}
