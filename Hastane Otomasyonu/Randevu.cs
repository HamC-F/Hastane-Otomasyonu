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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    // Parametreleri SqlParameter kullanarak belirtmek
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Apptab VALUES (@AppID, @PatientName, @DoctorName, @AppointmentDate)", con))
                    {
                        cmd.Parameters.AddWithValue("@AppID", SqlDbType.Int).Value = int.TryParse(txtappID.Text, out int appID) ? (object)appID : DBNull.Value;
                        cmd.Parameters.AddWithValue("@PatientName", SqlDbType.NVarChar).Value = patientname.Text;
                        cmd.Parameters.AddWithValue("@DoctorName", SqlDbType.NVarChar).Value = comboBox1.Text;
                        cmd.Parameters.AddWithValue("@AppointmentDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
                        

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
            SqlCommand cmd = new SqlCommand("select * from Apptab", con);
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

                        using (SqlCommand cmd = new SqlCommand("UPDATE Apptab SET PatientName = @PatientName,  DoctorName = @DoctorName WHERE AppointmentDate = @AppointmentDate", con))
                        {
                            // Parametrelerin belirtilmesi
                            cmd.Parameters.AddWithValue("@PatientName", SqlDbType.NVarChar).Value = patientname.Text;
                            cmd.Parameters.AddWithValue("@DoctorName", SqlDbType.NVarChar).Value = comboBox1.Text;
                            cmd.Parameters.AddWithValue("@AppointmentDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;

                            // Komutun çalıştırılması
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Updated Successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No records updated.");
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    if (string.IsNullOrEmpty(txtappID.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(patientname.Text))
                    {
                        MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz");
                    }
                    else
                    {
                        MessageBox.Show("Are you sure you want to delete?");

                        // Silme işlemi
                        SqlCommand cmd = new SqlCommand("DELETE FROM Apptab WHERE AppID=@AppID", con);
                        cmd.Parameters.AddWithValue("@AppID", txtappID.Text);
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
            txtappID.Clear();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospitaldbDataSet2.Patientab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.patientabTableAdapter.Fill(this.hospitaldbDataSet2.Patientab);
            // TODO: Bu kod satırı 'hospitaldbDataSet1.Doctortab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doctortabTableAdapter.Fill(this.hospitaldbDataSet1.Doctortab);

        }
    }
}
