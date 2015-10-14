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
    class DAODemande : DAOConn
    {
        

        public DAODemande() : base()
        {
            
            
        }
        public DataSet GetAllDemandesInDataSet()
        {
            DataSet dataSet1;
            string req = "select * from demande";
            //on crée un  dataset associé à cette connexion
            dataSet1 = new DataSet(myConnectionString);
            dataSet1.Tables.Clear();
            //on prépare la commande (texte de la requete passée en paramètre, connection)
            MySqlCommand requete = new MySqlCommand(req, conn);
            //on réceptionne le résultat dans le dataset
            MySqlDataAdapter resultat;
            resultat = new MySqlDataAdapter(requete);
            resultat.Fill(dataSet1);

            return dataSet1;
        }
        public void Chargergrid(string req)
        {

            //ChargerDataset(req);

        }
        
               
    }
}
