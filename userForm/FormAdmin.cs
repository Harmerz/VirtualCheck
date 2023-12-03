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
using Npgsql;

namespace userForm
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }

        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvDataPasien.DataSource = null;
                sql = "select * from st_select_booking()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvDataPasien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvDataDokter.DataSource = null;
                sql = "select * from st_select_doctor()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvDataDokter.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                r = dgvDataPasien.Rows[e.RowIndex];
            }
        }

        private void dgvDataDokter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                r = dgvDataDokter.Rows[e.RowIndex];
            }
        }

        private void btnDeletePasien_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar Anda ingin menghapus data " + r.Cells["_name"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete_booking(:_id_pasien)";
                    cmd = new NpgsqlCommand(sql, conn);

                    // Convert the parameter to integer
                    cmd.Parameters.AddWithValue("_id_pasien", Convert.ToInt32(r.Cells["_id_pasien"].Value));

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnPasien.PerformClick();  // Refresh the data
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // delete dokter masih error karena foreign key @haikal
        private void btnDeleteDokter_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar Anda ingin menghapus data " + r.Cells["_nama"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select st_delete_doctor(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);

                    // Convert the parameter to integer
                    cmd.Parameters.AddWithValue("_id", Convert.ToInt32(r.Cells["_id"].Value));

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnDokter.PerformClick();  // Refresh the data
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateDokter_Click(object sender, EventArgs e)
        {
            Dokter dokter = new Dokter();
            FormAddDoctor formAddDoctor = new FormAddDoctor(dokter);
            this.Close();
            formAddDoctor.ShowDialog();
        }

        private void btnUpdateDokter_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diUpdate", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dokter dokter = new Dokter();
            dokter.IDDokter = int.Parse(r.Cells["_id"].Value.ToString());
            dokter.NameDokter = r.Cells["_nama"].Value.ToString();
            dokter.UsernameDokter = r.Cells["_username"].Value.ToString();
            dokter.PasswordDokter = r.Cells["_password"].Value.ToString();
            dokter.HospitalDokter = r.Cells["_rs"].Value.ToString();
            dokter.KotaDokter = r.Cells["_kota"].Value.ToString();
            dokter.ProvinsiDokter = r.Cells["_provinsi"].Value.ToString();
            dokter.SpecialistDokter = r.Cells["_spesialis"].Value.ToString();
            dokter.DayDokter = r.Cells["_day"].Value.ToString();


            FormAddDoctor formAddDoctor = new FormAddDoctor(dokter);
            this.Close();
            formAddDoctor.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // This code will be executed when the FormAdmin is first loaded

            // Call the btnPasien_Click event handler method
            btnPasien_Click(sender, e);
            btnDokter_Click(sender, e);

        }
    }
}
