using Npgsql;


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
        string connstring = "Host=http://20.205.32.88/;Port=5432;Username=postgres;Password=;Database=junpro_virtualcheck";


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

        }
    }
}