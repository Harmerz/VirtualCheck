using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Dokter dokter;
        public FormDokter()
        {
            InitializeComponent();
            conn = new NpgsqlConnection();
            dokter = new Dokter();
            MessageBox.Show(dokter.IDDokter.ToString());
        }

        private NpgsqlConnection conn;

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
                sql = "select * from st_select_booking()";
                cmd = new NpgsqlCommand(sql, conn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (r == null)

            {

                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }

            if (MessageBox.Show("Apakah benar Anda ingin menghapus data " + r.Cells["_name"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                try
                {

                    conn.Open();
                    sql = @"select * from st_delete_booking(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)

                    {
                        MessageBox.Show("Data berhasil di hapus", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        button1.PerformClick();
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
