using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userForm
{
    public partial class FormLokasi : Form
    {
        private Pasien _pasien;
        public FormLokasi(Pasien pasien)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            _pasien = pasien;
            SetupProvinceAutocomplete();
        }
        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];


        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"Name: {_pasien.NamePasien}\nAddress: {_pasien.AdressPasien}\nGender: {_pasien.sexPasien}\nPhone: {_pasien.TelpPasien}\nAge: {_pasien.AgePasien}\nComplaint: {_pasien.KeluhanPasien}\nState: {txtProvince.Text}\nDistrict: {cbDistric.Text}\nHospital: {cbHospital.Text}";
            string id = "";
            MessageBox.Show(message, "Collected Data");

            string selectedHospital = cbHospital.Text;
            string selectedDistric = cbDistric.Text;
            string selectedSpesialis = cbSpesialis.Text;
            string selectedDoctor = cbDoctor.Text;
            string selectedDay = cbDays.Text;


            if (!string.IsNullOrEmpty(selectedHospital) && !string.IsNullOrEmpty(selectedDistric) && !string.IsNullOrEmpty(selectedSpesialis) && !string.IsNullOrEmpty(selectedDoctor) && !string.IsNullOrEmpty(selectedDay))
            {
                try
                {
                    conn.Open();

                    string idQuery = $"SELECT DISTINCT id FROM doctor WHERE rs ILIKE '{selectedHospital}' AND kota ILIKE '{selectedDistric}' AND spesialis ILIKE '{selectedSpesialis}' AND nama ILIKE '{selectedDoctor}' AND day ILIKE '{selectedDay}'";
                    MessageBox.Show(idQuery);
                    using (NpgsqlCommand command = new NpgsqlCommand(idQuery, conn))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming "id" is the column you want to retrieve
                                id = reader["id"].ToString();

                                // Process or use the retrieved value as needed
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show($"Please fill the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                conn.Open();

                // Insert into the "booking" table
                string insertQuery = "INSERT INTO booking (id_dokter, name, address, sex, telp, age, keluhan) " +
                                     "VALUES (@id_dokter, @name, @address, @sex, @telp, @age, @keluhan)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, conn))
                {
                    // Assuming "id_dokter" is the name of the column corresponding to the doctor's ID
                    command.Parameters.AddWithValue("@id_dokter", int.Parse(id)); // Use the actual value or variable

                    // Assuming these are the column names in the "booking" table
                    command.Parameters.AddWithValue("@name", _pasien.NamePasien);
                    command.Parameters.AddWithValue("@address", _pasien.AdressPasien);
                    command.Parameters.AddWithValue("@sex", _pasien.sexPasien);
                    command.Parameters.AddWithValue("@telp", _pasien.TelpPasien);
                    command.Parameters.AddWithValue("@age", _pasien.AgePasien);
                    command.Parameters.AddWithValue("@keluhan", _pasien.KeluhanPasien);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        conn.Close();
                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show("Failed to insert booking record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }


        private void SetupProvinceAutocomplete()
        {
            try
            {
                conn.Open();

                // Fetch data from the PostgreSQL database
                string query = "SELECT DISTINCT provinsi FROM doctor";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> provinceList = new List<string>();

                        while (reader.Read())
                        {
                            // Add the fetched province values to the list
                            string province = reader["provinsi"].ToString();
                            provinceList.Add(province);
                        }

                        // Set up autocomplete for txtProvince TextBox
                        txtProvince.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtProvince.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtProvince.AutoCompleteCustomSource.AddRange(provinceList.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log or display an error message)
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void txtProvince_TextChanged(object sender, EventArgs e)
        {
            // Handle the province selection change event
            string selectedProvince = txtProvince.Text;

            if (!string.IsNullOrEmpty(selectedProvince))
            {
                // Fetch districts based on the selected province
                try
                {
                    conn.Open();

                    string districtQuery = $"SELECT DISTINCT kota FROM doctor WHERE provinsi ILIKE '{selectedProvince}'";
                    using (NpgsqlCommand districtCommand = new NpgsqlCommand(districtQuery, conn))
                    {
                        using (NpgsqlDataReader districtReader = districtCommand.ExecuteReader())
                        {
                            List<string> districtList = new List<string>();

                            while (districtReader.Read())
                            {
                                string district = districtReader["kota"].ToString();
                                districtList.Add(district);
                            }

                            // Set the districts in the cbDistric ComboBox
                            cbDistric.Items.Clear();
                            cbDistric.Items.AddRange(districtList.ToArray());

                            // Show a message if the district list is empty
                            if (districtList.Count == 0)
                            {
                                MessageBox.Show("No matching districts found for the selected province.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cbKota_TextChange(object sender, EventArgs e)
        {
            string selectedDistric = cbDistric.Text;

            if (!string.IsNullOrEmpty(selectedDistric))
            {
                try
                {
                    conn.Open();

                    string hospitalQuery = $"SELECT DISTINCT rs FROM doctor WHERE kota ILIKE '{selectedDistric}'";
                    using (NpgsqlCommand hospitalCommand = new NpgsqlCommand(hospitalQuery, conn))
                    {
                        using (NpgsqlDataReader hospitalReader = hospitalCommand.ExecuteReader())
                        {
                            List<string> hospitalList = new List<string>();

                            while (hospitalReader.Read())
                            {
                                string hospital = hospitalReader["rs"].ToString();
                                hospitalList.Add(hospital);
                            }

                            cbHospital.Items.Clear();
                            cbHospital.Items.AddRange(hospitalList.ToArray());

                            if (hospitalList.Count == 0)
                            {
                                MessageBox.Show("No matching hospital's found for the selected Kota.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cbHospital_TextChange(object sender, EventArgs e)
        {
            string selectedHospital = cbHospital.Text;
            string selectedDistric = cbDistric.Text;

            if (!string.IsNullOrEmpty(selectedHospital) && !string.IsNullOrEmpty(selectedDistric))
            {
                try
                {
                    conn.Open();

                    string spesialisQuery = $"SELECT DISTINCT spesialis FROM doctor WHERE rs ILIKE '{selectedHospital}' AND kota ILIKE '{selectedDistric}'";
                    using (NpgsqlCommand spesialisCommand = new NpgsqlCommand(spesialisQuery, conn))
                    {
                        using (NpgsqlDataReader spesialisReader = spesialisCommand.ExecuteReader())
                        {
                            List<string> spesialisList = new List<string>();

                            while (spesialisReader.Read())
                            {
                                string spesialis = spesialisReader["spesialis"].ToString();
                                spesialisList.Add(spesialis);
                            }

                            cbSpesialis.Items.Clear();
                            cbSpesialis.Items.AddRange(spesialisList.ToArray());

                            if (spesialisList.Count == 0)
                            {
                                MessageBox.Show("No matching spesialis's found for the selected hospital.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cbSpesialis_TextChange(object sender, EventArgs e)
        {
            string selectedHospital = cbHospital.Text;
            string selectedDistric = cbDistric.Text;
            string selectedSpesialis = cbSpesialis.Text;

            if (!string.IsNullOrEmpty(selectedHospital) && !string.IsNullOrEmpty(selectedDistric) && !string.IsNullOrEmpty(selectedSpesialis))
            {
                try
                {
                    conn.Open();

                    string namaQuery = $"SELECT DISTINCT nama FROM doctor WHERE rs ILIKE '{selectedHospital}' AND kota ILIKE '{selectedDistric}' AND spesialis ILIKE '{selectedSpesialis}'";
                    using (NpgsqlCommand namaCommand = new NpgsqlCommand(namaQuery, conn))
                    {
                        using (NpgsqlDataReader namaReader = namaCommand.ExecuteReader())
                        {
                            List<string> namaList = new List<string>();

                            while (namaReader.Read())
                            {
                                string nama = namaReader["nama"].ToString();
                                namaList.Add(nama);
                            }

                            cbDoctor.Items.Clear();
                            cbDoctor.Items.AddRange(namaList.ToArray());

                            if (namaList.Count == 0)
                            {
                                MessageBox.Show("No matching doctor's found for the selected Spesialis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void cbDoctor_TextChange(object sender, EventArgs e)
        {
            string selectedHospital = cbHospital.Text;
            string selectedDistric = cbDistric.Text;
            string selectedSpesialis = cbSpesialis.Text;
            string selectedDoctor = cbDoctor.Text;


            if (!string.IsNullOrEmpty(selectedHospital) && !string.IsNullOrEmpty(selectedDistric) && !string.IsNullOrEmpty(selectedSpesialis) && !string.IsNullOrEmpty(selectedDoctor))
            {
                try
                {
                    conn.Open();

                    string dayQuery = $"SELECT DISTINCT day FROM doctor WHERE rs ILIKE '{selectedHospital}' AND kota ILIKE '{selectedDistric}' AND spesialis ILIKE '{selectedSpesialis}' AND nama ILIKE '{selectedDoctor}'";
                    using (NpgsqlCommand dayCommand = new NpgsqlCommand(dayQuery, conn))
                    {
                        using (NpgsqlDataReader dayReader = dayCommand.ExecuteReader())
                        {
                            List<string> dayList = new List<string>();

                            while (dayReader.Read())
                            {
                                string day = dayReader["day"].ToString();
                                dayList.Add(day);
                            }

                            cbDays.Items.Clear();
                            cbDays.Items.AddRange(dayList.ToArray());

                            if (dayList.Count == 0)
                            {
                                MessageBox.Show("No matching day's found for the selected Doctor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }



    }
}
