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
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPasien formPasien = new FormPasien();
            formPasien.Show();
        }
    }
}
