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
    public partial class KullanıcıGirişi : Form
    {
        public KullanıcıGirişi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastalar ht = new Hastalar();
            ht.Show();
            
        }

        private void KullanıcıGirişi_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {       
            GirisEkrani gr = new GirisEkrani();
            gr.Show();
            this.Close();
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
