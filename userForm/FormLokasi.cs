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

            /*  try
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
                  }
                  else
                  {
                      MessageBox.Show("Data gagal di inputkan", "We Are Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
        }
    }
}
