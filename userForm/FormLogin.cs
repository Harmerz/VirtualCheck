﻿using System;
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

           

                if (Role == "Admin")
                {
                    Close();
                    FormAdmin formAdmin = new();
                    formAdmin.Show();
                } else if (Role != "-1")
                {
                    Close();
                    FormDokter formDokter = new FormDokter(Role);
                    formDokter.Show();
                }

            textBox1.Text = "";
                textBox2.Text = "";


        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAwal formAwal = new FormAwal();
            formAwal.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

       
    }

}
