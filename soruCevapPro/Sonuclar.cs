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
    public partial class Sonuclar : Form
    {
        public Sonuclar()
        {
            InitializeComponent();
        }

        private void Sonuclar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sinavlar.ID as 'SIRANO', kisiID as 'KİŞİ NO', adSoyad as 'Ad-Soyad', tarih as 'Tarih',  puan as 'Puan' from sinavlar inner join kisiler ON sinavlar.kisiID = kisiler.ID ", Baglanti.baglan());
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sinavlar.ID as 'SIRANO', kisiID as 'KİŞİ NO', adSoyad as 'Ad-Soyad', tarih as 'Tarih',  puan as 'Puan' from sinavlar inner join kisiler ON sinavlar.kisiID = kisiler.ID  where kisiID like '"+textBox1.Text+"%'", Baglanti.baglan());
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
