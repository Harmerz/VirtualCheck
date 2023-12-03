using Npgsql;
using System.Configuration;
using System.Data;
using System.Xml.Linq;


namespace userForm
{
    public partial class FormPasien : Form
    {
        private Pasien pasien;
        public FormPasien()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            pasien = new Pasien();
        }

        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];


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
            pasien.NamePasien = txtNama.Text;
            int age;
            if (int.TryParse(txtUmur.Text, out age))
            {
                pasien.AgePasien = age;
            }
            else
            {
                MessageBox.Show("Invalid age input. Please enter a valid number.");
                return;
            }

            if (cbKelamin.Text == "Laki-laki")
            {
                pasien.sexPasien = true;
            }
            else if (cbKelamin.Text == "Perempuan")
            {
                pasien.sexPasien = false;
            }
            else
            {
                MessageBox.Show("Invalid gender input. Please select 'Laki-laki' or 'Perempuan'.");
                return;
            }
            pasien.AdressPasien = txtAlamat.Text;
            pasien.KeluhanPasien = txtKeluhan.Text;
            pasien.TelpPasien = txtTelp.Text;
            FormLokasi formLokasi = new FormLokasi(pasien);
            this.Close();
            formLokasi.Show();
        }

        private void cbKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormPasien_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            FormAwal formAwal = new FormAwal();
            this.Close();
            formAwal.Show();
        }
    }
}