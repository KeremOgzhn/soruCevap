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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        private void Sorular_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select ID as 'NUMARA', soruMetni as 'Soru Metni', aSec as 'A Seçeneği ', bSec as 'B Seçeneği ', cSec as 'C Seçeneği ', dSec as 'D Seçeneği ', dogruCevap as 'Dogru Cevap'    from sorular ", Baglanti.baglan());
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
    }
}
