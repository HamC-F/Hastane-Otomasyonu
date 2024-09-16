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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    // Parametreleri SqlParameter kullanarak belirtmek
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO paytab VALUES (@PID, @PaymentMethod, @PatientName, @Amount)", con))
                    {
                        cmd.Parameters.AddWithValue("@PID", SqlDbType.Int).Value = int.TryParse(txtPID.Text, out int PID) ? (object)PID : DBNull.Value;
                        cmd.Parameters.AddWithValue("@PaymentMethod", SqlDbType.NVarChar).Value = payment.Text;
                        cmd.Parameters.AddWithValue("@PatientName", SqlDbType.NVarChar).Value = PatientName.Text;
                        cmd.Parameters.AddWithValue("@Amount", SqlDbType.NVarChar).Value = howmoney.Text;
                        

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Saved Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No records inserted.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndisPlay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from paytab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE paytab SET PaymentMethod = @PaymentMethod, PatientName = @PatientName, Amount = @Amount  WHERE PID = @PID", con);
                        cmd.Parameters.AddWithValue("@PID", txtPID.Text);
                        cmd.Parameters.AddWithValue("@PaymentMethod", payment.Text);
                        cmd.Parameters.AddWithValue("@PatientName", PatientName.Text);
                        cmd.Parameters.AddWithValue("@Amount", howmoney.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record Updated Successfully!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    if (string.IsNullOrEmpty(txtPID.Text) || string.IsNullOrEmpty(howmoney.Text) || string.IsNullOrEmpty(PatientName.Text) || string.IsNullOrEmpty(payment.Text) )
                    {
                        MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz");
                    }
                    else
                    {
                        MessageBox.Show("Are you sure you want to delete?");

                        // Silme işlemi
                        SqlCommand cmd = new SqlCommand("DELETE FROM paytab WHERE PID=@PID", con);
                        cmd.Parameters.AddWithValue("@PID", txtPID.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("İşlem tamamlandı");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            howmoney.Clear();
            txtPID.Clear();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ödeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospitaldbDataSet2.Patientab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.patientabTableAdapter.Fill(this.hospitaldbDataSet2.Patientab);

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
