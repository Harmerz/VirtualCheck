using Npgsql;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace userForm
{
    internal class Admin
    {
        private int _idAdmin;
        private char[] _nameAdmin;
        private string _usernameAdmin;
        private string _passwordAdmin;
        private char[] _tempatAdmin;
        string connstring = ConfigurationManager.AppSettings["connstring"];

        private NpgsqlConnection conn;

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

        public bool LoginAdmin(string username, string password)
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
                    MessageBox.Show($"Login admin success, welcome {username}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
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
