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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KisiEkle ke = new KisiEkle();
            ke.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoruEkle se = new SoruEkle();
            se.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kisiler k = new Kisiler();
            k.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sorular s = new Sorular();
            s.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinavYap sy = new SinavYap();
            sy.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sonuclar s = new Sonuclar();
            s.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
