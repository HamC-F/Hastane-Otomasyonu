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
    public partial class Hastalar : Form
    {
        public Hastalar()
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Patientab VALUES (@PatientID, @PatientName, @Gender, @Email, @Address)", con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = int.TryParse(txtpatientID.Text, out int patientID) ? (object)patientID : DBNull.Value;
                        cmd.Parameters.AddWithValue("@PatientName", SqlDbType.NVarChar).Value = txtpatientName.Text;
                        cmd.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = txtpatinetGender.Text;
                        cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = txtpatientEmail.Text;
                        cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = txtpatientAddress.Text;

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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Patientab SET PatientName = @PatientName, Gender = @Gender, Email = @Email, Address = @Address WHERE PatientID = @PatientID", con);
                        cmd.Parameters.AddWithValue("@PatientID", txtpatientID.Text);
                        cmd.Parameters.AddWithValue("@PatientName", txtpatientName.Text);
                        cmd.Parameters.AddWithValue("@Gender", txtpatinetGender.Text);
                        cmd.Parameters.AddWithValue("@Email", txtpatientEmail.Text);
                        cmd.Parameters.AddWithValue("@Address", txtpatientAddress.Text);
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

                    if (string.IsNullOrEmpty(txtpatientID.Text) || string.IsNullOrEmpty(txtpatientName.Text) || string.IsNullOrEmpty(txtpatinetGender.Text) || string.IsNullOrEmpty(txtpatientEmail.Text) || string.IsNullOrEmpty(txtpatientAddress.Text))
                    {
                        MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz");
                    }
                    else
                    {
                        MessageBox.Show("Are you sure you want to delete?");

                        // Silme işlemi
                        SqlCommand cmd = new SqlCommand("DELETE FROM Patientab WHERE PatientID=@PatientID", con);
                        cmd.Parameters.AddWithValue("@PatientID", txtpatientID.Text);
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

        private void btndisPlay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Patientab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpatientID.Clear();
            txtpatientName.Clear();
            txtpatinetGender.Clear();
            txtpatientEmail.Clear();
            txtpatientAddress.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}

