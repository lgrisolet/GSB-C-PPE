using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacie
{
    public partial class Form3 : Form
    {


        private int leNumeroDemande;
        private string laDate;
        private string ladateD;
        private string ladateF;
        private string laRemarque;
        private int leProduit=3;

        public Form3(int leCode, string laDate, string laDateDb, string laDateFn, string laRm)
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
            this.textBox1.Text = this.leNumeroDemande.ToString();
            this.textBox2.Text = this.laDate.ToString();
            this.textBox3.Text = this.ladateD;
            this.textBox4.Text = this.ladateF;
            this.richTextBox1.Text = this.laRemarque;
        }


        public static object TextBox1 { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAODemande d = new DAODemande();
            MySqlCommand req = new MySqlCommand("UPDATE demande SET debut = '" + textBox3.Text + "', fin =' " + textBox4.Text + "', remarque = '" + richTextBox1.Text + "', idProduit = " + leProduit + " WHERE idDemande = " + textBox1.Text+",");
            req.ExecuteNonQuery();
            
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide(); ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox3.SelectedItem.ToString();

            switch(a)
            {
                case "XLS":
                    {
                        leProduit = 1;
                        
                    }break;
                case "Strepsil":
                    {
                        leProduit = 2;

                    }
                    break;
                case "Smecta":
                    {
                        leProduit = 3;

                    }
                    break;                  

            }

        }
    }
}
