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


    }
}
