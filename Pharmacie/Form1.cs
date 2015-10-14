using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DAOUser daoU = new DAOUser();
            if (daoU.autoriserConnexionUser(textBox1.Text, textBox2.Text))
            {
                
                this.Hide();
               
                Form2 Form2 = new Form2();
                Form2.Show();
                

            }
            else
            {
                Console.WriteLine("Mot de passe incorrect ou login incorrect");
            }
            
            }
        }
    }

