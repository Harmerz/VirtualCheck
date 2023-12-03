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
    public partial class Appoiment : Form
    {
        private Booking _booking;

        private string[] timeString = {
            "07.00 - 08.00", "08.00 - 09.00", "09.00 - 10.00",
            "10.00 - 11.00", "11.00 - 12.00", "12.00 - 13.00",
            "13.00 - 14.00", "14.00 - 15.00", "15.00 - 16.00"

        };

        public Appoiment(Booking booking)
        {
            InitializeComponent();
            Random random = new Random();

            int randomIndex = random.Next(0, timeString.Length);

            txtTime.Text = timeString[randomIndex];

            txtTime.Text = timeString[randomIndex];
            _booking = booking;
            txtDay.Text = _booking.Day;
            txtDoctor.Text = _booking.NameDokter;
            txtHospital.Text = _booking.Hospital;
            txtName.Text = _booking.NamePasien;
            txtKeluhan.Text = _booking.Keluhan;
        }

        private void Appoiment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAwal formAwal = new FormAwal();
            formAwal.Show();
        }
    }
}
