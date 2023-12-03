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
    public partial class FormDokter : Form
    {
        public FormDokter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOutDokter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOutDokter_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
