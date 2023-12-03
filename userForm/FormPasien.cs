using Npgsql;
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
        string connstring = "";

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
            // Convert txtUmur.Text to an integer
            int age;
            if (int.TryParse(txtUmur.Text, out age))
            {
                pasien.AgePasien = age;
            }
            else
            {
                MessageBox.Show("Invalid age input. Please enter a valid number.");
                return; // Or set a default value, e.g., pasien.AgePasien = 0;
            }

            // Convert cbKelamin.Text to a boolean
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
                return; // Or set a default value, e.g., pasien.SexPasien = false;
            }
            pasien.AdressPasien = txtAlamat.Text;
            pasien.KeluhanPasien = txtKeluhan.Text;
            pasien.TelpPasien = txtTelp.Text;
            FormLokasi formLokasi = new FormLokasi(pasien);
            this.Close();
            formLokasi.ShowDialog();
        }

        private void cbKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormPasien_Load(object sender, EventArgs e)
        {

        }
    }
}