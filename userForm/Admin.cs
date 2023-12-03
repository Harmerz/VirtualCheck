using Npgsql;
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
        private string _usernameAdmin;
        private string _passwordAdmin;
        private char[] _tempatAdmin;

        private NpgsqlConnection conn;
        private const string connstring = "";
        public Admin()
        {
            conn = new NpgsqlConnection(connstring);
        }


        public static NpgsqlCommand cmd;
        private string sql = null;

        public int IDAdmin
        {
            get { return _idAdmin; }
        }

        public char[] NameAdmin
        {
            get { return _nameAdmin; }
            set { _nameAdmin = value; }
        }

        public string UsernameAdmin
        {
            get { return _usernameAdmin; }
            set { _usernameAdmin = value; }
        }
        public string PasswordAdmin
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

            try
            {
                conn.Open();
                sql = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }


    }
}
