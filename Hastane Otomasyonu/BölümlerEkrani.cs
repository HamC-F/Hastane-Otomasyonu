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
    public partial class BölümlerEkrani : Form
    {
        public BölümlerEkrani()
        {
            InitializeComponent();
        }

          private void btnSave_Click(object sender, EventArgs e)
        {
            //kaydet
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into deptab values(@DeptID,@DeptName,@Phone)", con);
            cmd.Parameters.AddWithValue("@DeptID", int.Parse(txtdepID.Text));
            cmd.Parameters.AddWithValue("@DeptName", (txtdepName.Text));
            cmd.Parameters.AddWithValue("@Phone", (txtdepPhone.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        } 
       

         private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            {
                SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE deptab SET DeptName = @DeptName, Phone = @Phone WHERE DeptID = @DeptID", con);
                    cmd.Parameters.AddWithValue("@DeptID", int.Parse(txtdepID.Text));
                    cmd.Parameters.AddWithValue("@DeptName", txtdepName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtdepPhone.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        } private void button5_Click(object sender, EventArgs e)
        {
            //Sil
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete deptab where DeptID=@DeptID  ", con);
            cmd.Parameters.AddWithValue("@DeptID", int.Parse(txtdepID.Text));
            if ((txtdepID == null) && (txtdepName == null) && (txtdepPhone == null))
            {
                MessageBox.Show("Lütfen Tum Kutucukları doldurunuz");
            }
            else
            {
                MessageBox.Show("İşlem tamamlandı");
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Are you sure you want to delete?");
           
        }

        private void btndisPlay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from deptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BölümlerEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from deptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
        int toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlaç Kazandınız");
            toplam += 1;
            label5.Text = "Toplam" + toplam.ToString();
            if (toplam>=10)
            {
                MessageBox.Show("Hastaneden %80 indirim kazandınız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdepID.Clear();
            txtdepName.Clear();
            txtdepPhone.Clear();
        }
    }
}