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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Role = Login.HandleLogin(textBox1.Text, textBox2.Text);

            if (Role == "Admin" || Role == "Dokter")
            {
                MessageBox.Show("Masuk bro");
                if (Role == "Dokter")
                {
                    Close();
                    FormDokter formDokter = new();
                    formDokter.Show();
                }

                if (Role == "Admin")
                {
                    Close();
                    FormAdmin formAdmin = new();
                    formAdmin.Show();
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Gagal bro");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPasien_Click(object sender, EventArgs e)
        {
            Close();
            FormPasien formPasien = new();
            formPasien.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
