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
    public partial class SoruEkle : Form
    {
        public SoruEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtSmetni.Text == "" || txtAsec.Text  == "" || txtBsec.Text == "" || txtCsec.Text == "" || txtDsec.Text == "" || txtDcevap.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !", "Eksik Kayit ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into sorular ( soruMetni, asec, bsec, csec, dsec, dogrucevap ) values ( @p1, @p2, @p3, @p4, @p5, @p6 )  ", Baglanti.baglan());
                if (Baglanti.baglan().State != ConnectionState.Open)
                {
                    Baglanti.baglan().Open();
                }
                komut.Parameters.AddWithValue("@p1", txtSmetni.Text);
                komut.Parameters.AddWithValue("@p2", txtAsec.Text);
                komut.Parameters.AddWithValue("@p3", txtBsec.Text);
                komut.Parameters.AddWithValue("@p4", txtCsec.Text);
                komut.Parameters.AddWithValue("@p5", txtDsec.Text);
                komut.Parameters.AddWithValue("@p6", txtDcevap.Text) ; 

                komut.ExecuteNonQuery();
                MessageBox.Show("Soru Kaydı Tamam ", "Soru kayıt işlemi");
            }
            txtSmetni.Text = "";
            txtAsec.Text = "";
            txtBsec.Text = "";
            txtCsec.Text = "";
            txtDsec.Text = "";
            txtDcevap.Text = ""; 

        }
    }
}
