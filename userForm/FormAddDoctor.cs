using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace userForm
{
    public partial class FormAddDoctor : Form
    {
        private Dokter _dokter;
        public FormAddDoctor(Dokter dokter)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            _dokter = dokter;
            if (_dokter.IDDokter != 0)
            {
                txtNama.Text = _dokter.NameDokter;
                txtUsername.Text = _dokter.UsernameDokter;
                txtPassword.Text = _dokter.PasswordDokter;
                txtSpesialis.Text = _dokter.SpecialistDokter;
                txtKota.Text = _dokter.KotaDokter;
                txtDay.Text = _dokter.DayDokter;
                txtProvince.Text = _dokter.ProvinsiDokter;
                txtHospital.Text = _dokter.HospitalDokter;
            }
        }
        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];


        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void back_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Close();
            formAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Your existing code to insert or update the doctor goes here

                // Check if dokter.IDDokter is not null and update the table
                if (_dokter.IDDokter != 0) // Assuming 0 means null for your ID field
                {
                    // Create an SQL UPDATE statement
                    string updateQuery = "UPDATE doctor SET nama = @nama, username = @username, password = @password, day = @day, rs = @rs, spesialis = @spesialis, kota = @kota, provinsi = @provinsi WHERE id = @id";

                    // Create a command with parameters
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _dokter.IDDokter);
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@day", txtDay.Text);
                        cmd.Parameters.AddWithValue("@rs", txtHospital.Text);
                        cmd.Parameters.AddWithValue("@spesialis", txtSpesialis.Text);
                        cmd.Parameters.AddWithValue("@kota", txtKota.Text);
                        cmd.Parameters.AddWithValue("@provinsi", txtProvince.Text);

                        // Execute the UPDATE statement
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update doctor information.");
                        }
                    }
                }
                else
                {
                    string insertQuery = "INSERT INTO doctor (nama, username, password, day, rs, spesialis, kota, provinsi) VALUES (@nama, @username, @password, @day, @rs, @spesialis, @kota, @provinsi)";

                    // Create a command with parameters
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@day", txtDay.Text);
                        cmd.Parameters.AddWithValue("@rs", txtHospital.Text);
                        cmd.Parameters.AddWithValue("@spesialis", txtSpesialis.Text);
                        cmd.Parameters.AddWithValue("@kota", txtKota.Text);
                        cmd.Parameters.AddWithValue("@provinsi", txtProvince.Text);

                        // Execute the INSERT statement
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor information inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert doctor information.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            FormAdmin formAdmin = new FormAdmin();
            this.Close();
            formAdmin.Show();
        }
    }
}
