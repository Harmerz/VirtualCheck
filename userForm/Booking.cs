using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Booking
    {
        private char[] _namePasien;
        private char[] _nameDokter;
        private string _keluhan;
        private string _tempat;
        private DateTime _waktu;


        public char[] NamePasien
        {
            get { return _namePasien; }
            set { _namePasien = value; }
        }

        public char[] NameDokter
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
            get { return _tempat; }
            set { _tempat = value; }
        }

        public DateTime Waktu
        {
            get { return _waktu; }
            set { _waktu = value; }
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
