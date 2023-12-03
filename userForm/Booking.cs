using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Booking
    {
        private string _namePasien;
        private string _nameDokter;
        private string _keluhan;
        private string _hospital;
        private string _day;



        public string NamePasien
        {
            get { return _namePasien; }
            set { _namePasien = value; }
        }

        public string NameDokter
        {
            get { return _nameDokter; }
            set { _nameDokter = value; }
        }
        public string Keluhan
        {
            get { return _keluhan; }
            set { _keluhan = value; }
        }

        public string Tempat
        {
            get { return _hospital; }
            set { _hospital = value; }
        }

        public string Day
        {
            get { return _day; }
            set { _day = value; }
        }


        public static void listPasien(List<Booking> bookings)
        {
            Console.WriteLine("List of Patients:");
            foreach (var booking in bookings)
            {
                Console.WriteLine("Nama Pasien: " + new string(booking.NamePasien));
            }
        }
    }
}
