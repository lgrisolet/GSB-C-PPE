using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace pharmacie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dgv_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
     

        private void Form2_Load(object sender, EventArgs e)
        {
            DAODemande daoD = new DAODemande();
            dataGridView1.Visible = true;
            // on associe dataset et datagrid
            DataSet donnees = daoD.GetAllDemandesInDataSet();
            dataGridView1.DataSource = donnees;

            dataGridView1.DataMember = donnees.Tables[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //modifier le contenu
           
        }

       

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

 
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ajouter(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
     
    
    }

