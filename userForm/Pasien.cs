using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Pasien
    {
        private int _idPasien;
        private char[] _namePasien;
        private int _agePasien;
        private string _addressPasien;
        private bool _sexPasien;
        private string _telpPasien;
        private string _keluhan;

        public int IDPasien
        {
            get { return _idPasien; }
        }

        public char[] NamePasien
        {
            get { return _namePasien; }
            set { _namePasien = value; }
        }

        public int AgePasien
        {
            get { return _agePasien; }
            set { _agePasien = value; }
        }
        public string AdressPasien
        {
            get { return _addressPasien; }
            set { _addressPasien = value; }
        }

        public bool sexPasien
        {
            get { return _sexPasien; }
            set { _sexPasien = value; }
        }

        public string TelpPasien
        {
            get { return _telpPasien; }
            set { _telpPasien = value; }
        }
        public string KeluhanPasien
        {
            get { return _keluhan; }
            set { _keluhan = value; }
        }

        public Pasien(int idPasien, char[] namaPasien, int agePasien, string addressPasien, bool sexPasien, string telpPasien, string keluhan)
        {
            _idPasien = idPasien;
            _namePasien = namaPasien;
            _agePasien = agePasien;
            _addressPasien = addressPasien;
            _sexPasien = sexPasien;
            _telpPasien = telpPasien;
            _keluhan = keluhan;
        }

        public void mengisiDataPasien(int idPasien, char[] namaPasien, int agePasien, string addressPasien, bool sexPasien, string telpPasien, string keluhan)
        {
            _idPasien = idPasien;
            _namePasien = namaPasien;
            _agePasien = agePasien;
            _addressPasien = addressPasien;
            _sexPasien = sexPasien;
            _telpPasien = telpPasien;
            _keluhan = keluhan;
        }

        public void editDataPasien(char[] namaPasien, int agePasien, string addressPasien, bool sexPasien, string telpPasien, string keluhan)
        {
            _namePasien = namaPasien;
            _agePasien = agePasien;
            _addressPasien = addressPasien;
            _sexPasien = sexPasien;
            _telpPasien = telpPasien;
            _keluhan = keluhan;
        }

    }
}
