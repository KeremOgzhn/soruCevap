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
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }

        private void Kisiler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select ID as 'NUMARA', adSoyad as 'AD-SOYAD', meslek as 'MESLEK' from kisiler ", Baglanti.baglan());
            SqlDataAdapter da = new SqlDataAdapter(komut );

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo; 
        }
    }
}
