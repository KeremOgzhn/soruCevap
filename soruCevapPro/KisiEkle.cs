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

namespace soruCevapPro
{
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !", "Eksik Kayit ", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into kisiler ( adSoyad, meslek ) values ( @p1, @p2 )  ", Baglanti.baglan() );
                if (Baglanti.baglan().State != ConnectionState.Open )
                {
                    Baglanti.baglan().Open(); 
                }
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                
                komut.ExecuteNonQuery();
                MessageBox.Show("Kişi Kaydı Tamam ", "Kişi kayit işlemi"); 
            }
            textBox1.Text = "";
            textBox2.Text = ""; 
        }
    }
}
