using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }
        private NpgsqlConnection conn;
        string connstring = "";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"Name: {_pasien.NamePasien}\nAddress: {_pasien.AdressPasien}\nGender: {_pasien.sexPasien}\nPhone: {_pasien.TelpPasien}\nAge: {_pasien.AgePasien}\nComplaint: {_pasien.KeluhanPasien}\nDoctor ID: {cbProvince}";

            MessageBox.Show(message, "Collected Data");


             
        }
    }
}
