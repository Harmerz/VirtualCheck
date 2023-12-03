using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];

        public Dokter()
        {
            conn = new NpgsqlConnection(connstring);
        }


        public static NpgsqlCommand cmd;
        private string sql = null;
        public int IDDokter { 
            get { return _idDokter; }
            set { _idDokter = value;}
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

        public bool LoginDokter(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }

            try
            {
                conn.Open();
                sql = "SELECT nama, id FROM doctor WHERE username=@username AND password=@password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string doctorName = reader["nama"].ToString();
                        int IDDokter = int.Parse(reader["id"].ToString());
                        MessageBox.Show($"Welcome, {doctorName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
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
