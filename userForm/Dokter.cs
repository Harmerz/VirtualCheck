﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userForm
{
    public class Dokter
    {
        private int _idDokter;
        private string _nameDokter;
        private string _usernameDokter;
        private string _passwordDokter;
        private string _specialistDokter;
        private string _kotaDokter;
        private string _provinsiDokter;
        private string _hospitalDokter;
        private string _dayDokter;
        private List<string> _jadwalDokter = new List<string>();

        private NpgsqlConnection conn;
        string connstring = ConfigurationManager.AppSettings["connstring"];

        public Dokter()
        {
            conn = new NpgsqlConnection(connstring);
        }


        public static NpgsqlCommand cmd;
        private string sql = null;
        public int IDDokter
        {
            get { return _idDokter; }
            set { _idDokter = value; }
        }

        public string NameDokter
        {
            get { return _nameDokter; }
            set { _nameDokter = value; }
        }

        public string UsernameDokter
        {
            get { return _usernameDokter; }
            set { _usernameDokter = value; }
        }

        public string PasswordDokter
        {
            get { return _passwordDokter; }
            set { _passwordDokter = value; }
        }

        public string SpecialistDokter
        {
            get { return _specialistDokter; }
            set { _specialistDokter = value; }
        }

        public string KotaDokter
        {
            get { return _kotaDokter; }
            set { _kotaDokter = value; }
        }

        public string ProvinsiDokter
        {
            get { return _provinsiDokter; }
            set { _provinsiDokter = value; }
        }

        public string HospitalDokter
        {
            get { return _hospitalDokter; }
            set { _hospitalDokter = value; }
        }

        public string DayDokter
        {
            get { return _dayDokter; }
            set { _dayDokter = value; }
        }


        public int LoginDokter(string username, string password)
        {
            if (username == null || password == null)
            {
                return -1;
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
                        IDDokter = int.Parse(reader["id"].ToString());
                        MessageBox.Show($"Welcome, {doctorName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return IDDokter;
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
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


            return -1;
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
