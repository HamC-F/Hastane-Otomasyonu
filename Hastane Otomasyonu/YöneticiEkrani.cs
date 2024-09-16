using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class YöneticiEkrani : Form
    {
        
        public YöneticiEkrani()
        {
            InitializeComponent();
        }

        private void YöneticiEkrani_Load(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BölümlerEkrani böl = new BölümlerEkrani();
            böl.Show();
            
            

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            GirisEkrani gr = new GirisEkrani();
            gr.Show();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hastalar ht = new Hastalar();
            ht.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doktor dk = new Doktor();
            dk.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hemşire hm = new Hemşire();
            hm.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Randevu rd = new Randevu();
            rd.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ödeme öd = new Ödeme();
            öd.Show();
        }
    }
}
