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
            Admin admin = new Admin();
            admin.UsernameAdmin = textBox1.Text;
            admin.PasswordAdmin = textBox2.Text;    
            if (admin.LoginAdmin(admin.UsernameAdmin, admin.PasswordAdmin))
            {
                MessageBox.Show("Masuk bro");
            }
            else
            {
                MessageBox.Show("Gagal bro");
            }

        }
    }
}
