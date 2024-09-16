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
    public partial class Hemşire : Form
    {
        public Hemşire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnurseID.Clear();
            txtnurseName.Clear();
            txtphone.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=HAMSITAVA57\SQLEXPRESS;Initial Catalog=Hospitaldb;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Nursetab VALUES (@NurseID, @NurseName, @Phone)", con))
                    {
                        // Parametre türlerini belirtmek için SqlParameter kullanın
                        cmd.Parameters.Add("@NurseID", SqlDbType.Int).Value = int.TryParse(txtnurseID.Text, out int nurseID) ? (object)nurseID : DBNull.Value;
                        cmd.Parameters.Add("@NurseName", SqlDbType.NVarChar).Value = txtnurseName.Text;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtphone.Text;

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
            SqlCommand cmd = new SqlCommand("select * from Nursetab", con);
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

                        using (SqlCommand cmd = new SqlCommand("UPDATE Nursetab SET NurseName = @NurseName,  Phone = @Phone WHERE NurseID = @NurseID", con))
                        {
                            // Parametrelerin belirtilmesi
                            cmd.Parameters.AddWithValue("@NurseID", int.Parse(txtnurseID.Text));
                            cmd.Parameters.AddWithValue("@NurseName", txtnurseName.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);

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

                    if (string.IsNullOrEmpty(txtnurseID.Text) || string.IsNullOrEmpty(txtnurseName.Text)  || string.IsNullOrEmpty(txtphone.Text))
                    {
                        MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz");
                    }
                    else
                    {
                        MessageBox.Show("Are you sure you want to delete?");

                        // Silme işlemi
                        SqlCommand cmd = new SqlCommand("DELETE FROM Nursetab WHERE NurseID=@NurseID", con);
                        cmd.Parameters.AddWithValue("@NurseID", txtnurseID.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}


