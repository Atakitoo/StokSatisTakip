using MySql.Data.MySqlClient;   
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatisTakip.DAL.Helpers
{
    public class DatabaseHelper
    {
        private static readonly string connectionString =
            "Server=172.21.54.253;Database=26_132430053;Uid=26_132430053;Pwd=İnif123.;";

     
             public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            return conn;
        }
    }
}

