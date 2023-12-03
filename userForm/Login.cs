using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    internal class Login
    {
        public static String HandleLogin(string username, string password)
        {
            Admin admin = new();
            Dokter dokter = new();
            bool _admin = admin.LoginAdmin(username, password);
            if (username == null || password == null)
            {
                return "Please Fill the Blank";
            }
            if (_admin)
            {
                return "Admin";
            }
            int _dokter = dokter.LoginDokter(username, password);
            if(_dokter != -1)
            {
                return _dokter.ToString();
            }
            return "-1";
        }
    }
}
