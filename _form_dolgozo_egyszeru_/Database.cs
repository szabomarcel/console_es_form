using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _form_dolgozo_egyszeru_
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Database()
        {
            MySqlBaseConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozok";
            connection = new MySqlConnection();
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public List<Dolgozo> getPost()
        {
            nyit();
            List<Dolgozo> feltoltes = new List<Dolgozo>();
            command.CommandText = "SELECT `nev`, `neme`, `reszleg`, `belepesev`, `ber` FROM `dolgozok` WHERE 1 ORDER BY nev";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    feltoltes.Add(new Dolgozo(dr.GetString("nev"), dr.GetString("neme"), dr.GetString("reszleg"), dr.GetInt32("belepesev"), dr.GetInt32("ber")));
                }
            }
            zar();
            return feltoltes;
        }
    }
}
