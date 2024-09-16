using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Veritabanında kullanıcı adı ve şifre kontrolü yapacak bir SqlCommand nesnesi oluşturulur.
            // Bu sorguda, parametreli bir sorgu kullanılarak SQL enjeksiyonu riski azaltılır.
            SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM logintab WHERE Username = @Username AND Password = @Password", con);

            // Parametreli sorguda kullanılacak parametreler atanır.
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
           
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");
                YöneticiEkrani yt = new YöneticiEkrani();
                yt.Show();
                yt.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid username or password");
            }

            con.Close();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            string username = textBox2.Text;
            string password = textBox1.Text;

            // Veritabanında kullanıcı adı ve şifre kontrolü yapacak bir SqlCommand nesnesi oluşturulur.
            // Bu sorguda, parametreli bir sorgu kullanılarak SQL enjeksiyonu riski azaltılır.
            SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM NurseLogintab WHERE Username = @Username AND Password = @Password", con);

            // Parametreli sorguda kullanılacak parametreler atanır.
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");
                KullanıcıGirişi kg = new KullanıcıGirişi();
                kg.Show();
                kg.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid username or password");
            }

            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
