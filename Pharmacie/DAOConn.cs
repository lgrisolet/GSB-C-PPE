using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace pharmacie
{
    public abstract class DAOConn
    {
        protected  string myConnectionString;
        protected  MySqlConnection conn;

        public DAOConn()
        {

            myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=gsb;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

    }
}
