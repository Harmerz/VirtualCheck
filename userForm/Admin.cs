using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Admin
    {
        private int _idAdmin;
        private char[] _nameAdmin;
        private char[] _usernameAdmin;
        private char[] _passwordAdmin;
        private char[] _tempatAdmin;

        public int IDAdmin
        {
            get { return _idAdmin; }
        }

        public char[] NameAdmin
        {
            get { return _nameAdmin; }
            set { _nameAdmin = value; }
        }

        public char[] UsernameAdmin
        {
            get { return _usernameAdmin; }
            set { _usernameAdmin = value; }
        }
        public char[] PasswordAdmin
        {
            get { return _passwordAdmin; }
            set { _usernameAdmin = value; }
        }
        public char[] TempatAdmin
        {
            get { return _tempatAdmin; }
            set { _tempatAdmin = value; }
        }

        public Boolean LoginAdmin(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }
            // Dummy Data
            if (username == "Admin1" && password == "Password1") return true;
            if (username == "Admin2" && password == "Password2") return true;
            if (username == "Admin3" && password == "Password3") return true;
            return false;
        }


    }
}
