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
        string connstring = "Host=20.205.32.88;Port=5432;Username=postgres;Password=;Database=junpro_virtualcheck";

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
                sql = @"select * from insert_pasien(:_name, :_age, :_address, :_telp, :_keluhan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", txtNama.Text);
                cmd.Parameters.AddWithValue("_age", txtUmur.Text);
                cmd.Parameters.AddWithValue("_address", txtAlamat.Text);
                //cmd.Parameters.AddWithValue("_sex", cbKelamin.Text);
                cmd.Parameters.AddWithValue("_telp", txtTelp.Text);
                cmd.Parameters.AddWithValue("_keluhan", txtKeluhan.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    button1.PerformClick();
                    txtNama.Text = txtUmur.Text = txtAlamat.Text = txtTelp.Text = txtKeluhan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}