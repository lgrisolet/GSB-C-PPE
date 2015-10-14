using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pharmacie.DAOClasse
{
    class DAOUser
    {
        private MySqlConnection conn;

        public DAOUser()
        {
            string myConnectionString;
            //myConnectionString = "server=193.252.48.172;port=20433;uid=golfede;pwd=golfede;database=golfbdd;";
            myConnectionString = "server=127.0.0.1;port=3306;uid=root;pwd=;database=gsb;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }


    }
}
