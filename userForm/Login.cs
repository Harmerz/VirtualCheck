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
            if (username == null || password == null)
            {
                return "Please Fill the Blank";
            }
            if (Admin.LoginAdmin(username, password))
            {
                return "Admin";
            }
            else if(Dokter.LoginDokter(username, password))
            {
                return "Dokter";
            }
            return "Username or Password is Wrong";
        }
    }
}
