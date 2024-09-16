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
    public partial class Doktor : Form
    {
        public Doktor()
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

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Doctortab VALUES (@DoctorID, @DoctorName, @Experience, @Phone, @Department)", con))
                    {
                        // Parametre türlerini belirtmek için SqlParameter kullanın
                        cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = int.TryParse(txtdoctorID.Text, out int doctorID) ? (object)doctorID : DBNull.Value;
                        cmd.Parameters.Add("@DoctorName", SqlDbType.NVarChar).Value = txtdoctorName.Text;
                        cmd.Parameters.Add("@Experience", SqlDbType.NVarChar).Value = txtexperience.Text;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtphone.Text;
                        cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = department.Text;
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
            SqlCommand cmd = new SqlCommand("select * from Doctortab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    if (string.IsNullOrEmpty(txtdoctorID.Text) || string.IsNullOrEmpty(txtdoctorName.Text) || string.IsNullOrEmpty(txtexperience.Text) || string.IsNullOrEmpty(txtphone.Text) || string.IsNullOrEmpty(department.Text))
                    {
                        MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz");
                    }
                    else
                    {
                        MessageBox.Show("Are you sure you want to delete?");

                        // Silme işlemi
                        SqlCommand cmd = new SqlCommand("DELETE FROM Doctortab WHERE DoctorID=@DoctorID", con);
                        cmd.Parameters.AddWithValue("@DoctorID", txtdoctorID.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE Doctortab SET DoctorName = @DoctorName, Experience = @Experience, Phone = @Phone, Department = @Department WHERE DoctorID = @DoctorID", con))
                        {
                            // Parametrelerin belirtilmesi
                            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(txtdoctorID.Text));
                            cmd.Parameters.AddWithValue("@DoctorName", txtdoctorName.Text);
                            cmd.Parameters.AddWithValue("@Experience", txtexperience.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                            cmd.Parameters.AddWithValue("@Department", department.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            txtdoctorID.Clear();
            txtdoctorName.Clear();
            txtexperience.Clear();
            txtphone.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospitaldbDataSet3.deptab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.deptabTableAdapter.Fill(this.hospitaldbDataSet3.deptab);

        }
    }
}










