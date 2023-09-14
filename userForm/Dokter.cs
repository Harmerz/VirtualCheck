using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Dokter
    {
        private int _idDokter;
        private char[] _nameDokter;
        private char[] _usernameDokter;
        private char[] _passwordDokter;
        private char[] _tempatDokter;
        private List<string> _jadwalDokter = new List<string>();

        public int IDDokter { 
            get { return _idDokter; }
        }

        public char[] NameDokter { 
            get { return _nameDokter;}
            set { _nameDokter = value; }   
        }

        public char[] UsernameDokter { 
            get { return _usernameDokter; }
            set { _usernameDokter = value; }
        }
        public char[] PasswordDokter { 
            get { return _passwordDokter; } 
            set { _usernameDokter= value; }
        }
        public char[] TempatDokter
        {
            get { return _tempatDokter; }
            set { _tempatDokter = value; }
        }
        public List<string> JadwalDokter
        {
            get { return _jadwalDokter; }
            set { _jadwalDokter = value; }
        }

        public Boolean LoginDokter(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }
            // Dummy Data
            if (username == "Dokter1" && password == "Password1") return true;
            if (username == "Dokter2" && password == "Password2") return true;
            if (username == "Dokter3" && password == "Password3") return true;
            return false;
        }

        public void AddJadwal(string jadwal)
        {

            _jadwalDokter.Add(jadwal);
        }

        public void EditJadwal(string oldJadwal, string newJadwal)
        {

            int index = _jadwalDokter.FindIndex(s => s == oldJadwal);

            if (index != -1)
                _jadwalDokter[index] = newJadwal;
        }
    }
}
