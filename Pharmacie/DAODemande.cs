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
        private int leNumeroDemande;
        private int laDate;
        private string ladateD;
        private string ladateF;
        private string laRemarque;

        public Form3(int leCode, int laDate, string laDateDb, string laDateFn, string laRm)
        {
            this.leNumeroDemande = leCode;
            this.laDate = laDate;
            this.ladateD = laDateDb;
            this.ladateF = laDateFn;
            this.laRemarque = laRm;

            InitializeComponent();
            ModifierProduit();
        }

        public void ModifierProduit()
        {
            this.textBox1.Text = this.leNumeroDemande;
            this.textBox2.Text = this.laDate;
            this.textBox3.Text = this.ladateD;
            this.textBox4.Text = this.ladateF;
            this.richTextBox1.Text = this.laRemarque;
        }

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
