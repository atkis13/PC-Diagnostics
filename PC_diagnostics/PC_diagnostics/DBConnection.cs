using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace PC_diagnostics
{
    class DBConnection
    {

        MySqlConnection connect;
        private string username = "Ati";
        private string password = "test";

        public string Username { get => username; }
        public string Password { get => password; }

        public DBConnection()
        {
            string mycons = "SERVER=192.168.14.29;PORT=3306;DATABASE=pc_diag;UID=Ati;PASSWORD=test";
            connect = new MySqlConnection(mycons);
        }

        public void Open()
        {
            connect.Open();
        }

        public void Close()
        {
            connect.Close();
        }

        public MySqlConnection getConnection()
        {
            return connect;
        }

    }
}

