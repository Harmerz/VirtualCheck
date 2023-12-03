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
using Npgsql;

namespace userForm
{
    public partial class FormDokter : Form
    {
        string _idDokter;
        public FormDokter(string IdDokter)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            _idDokter = IdDokter;
        }

        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        private void btnLogOutDokter_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                // Use parameters in the query to prevent SQL injection
                sql = "SELECT * FROM booking WHERE id_dokter = @id_dokter";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_dokter", int.Parse(_idDokter));
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                r = dgvData.Rows[e.RowIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        button2.PerformClick();  // Refresh the data
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}