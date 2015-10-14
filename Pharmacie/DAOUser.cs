using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Data.SqlClient;

namespace pharmacie
{
    class DAOUser : DAOConn
    {
        
        public DAOUser() : base()
        {
           
        }

        public bool autoriserConnexionUser(String login, String mdp)
        {
            bool autorise = false;

            MySqlCommand cmd = new MySqlCommand("select count(*) from users where emailUser='" + login + "' and mdpUser='" + mdp + "'", conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int nb = Convert.ToInt16(dr[0].ToString());
            if (nb > 0)
            {
                autorise = true;
            }
            return autorise;
        }
    }
}
