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
    public partial class SinavYap : Form
    {
        public SinavYap()
        {
            InitializeComponent();
        }
        public static string adSoyad = "";
        public static int ID; 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""  )
            {
                MessageBox.Show("Lütfen Ad/Soyad Bilginizi Giriniz !", "Eksik Kayit ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from kisiler where adSoyad = @p1 ", Baglanti.baglan());
                
                if (Baglanti.baglan().State != ConnectionState.Open)
                {
                    Baglanti.baglan().Open();
                }

                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                SqlDataReader dr= komut.ExecuteReader();

                if ( ! dr.Read() )
                {
                    MessageBox.Show("Lütfen ad/soyad bilgilerinizi doğru giriniz, kayıtlı değilseniz önce kayıt olunuz !!! ","Sınav Ekranı"  );
                }
                else
                {
                    adSoyad = dr["adSoyad"].ToString();
                    ID = int.Parse( dr["ID"].ToString() ) ; 
                    MessageBox.Show("Sınavınız başlıyor");
                    SinavStart ss = new SinavStart();
                    ss.Show(); 

                }

                






            }
            textBox1.Text = "";


        }
    }
}
