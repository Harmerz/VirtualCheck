using Npgsql;
using System.Data;
using System.Xml.Linq;


namespace userForm
{
    public partial class FormPasien : Form
    {
        public FormPasien()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }

        private NpgsqlConnection conn;
        string connstring = "Host=20.205.32.88;Port=5432;Username=postgres;Database=junpro_virtualcheck";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btnLogOutPasien_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormAwal formAwal = new FormAwal();
            formAwal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from insert_pasien(:_name, :_age, :_address, :_sex, :_telp, :_keluhan)";
                cmd = new NpgsqlCommand(sql, conn);
                Boolean sex = cbKelamin.Text == "Laki-laki";
                cmd.Parameters.AddWithValue("_name", txtNama.Text);
                cmd.Parameters.AddWithValue("_age", int.Parse(txtUmur.Text));
                cmd.Parameters.AddWithValue("_address", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_sex", sex);
                cmd.Parameters.AddWithValue("_telp", txtTelp.Text);
                cmd.Parameters.AddWithValue("_keluhan", txtKeluhan.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();   
                    txtNama.Text = txtUmur.Text = txtAlamat.Text = txtTelp.Text = txtKeluhan.Text = null;
                }else
                {
                    MessageBox.Show("Data gagal di inputkan", "We Are Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}