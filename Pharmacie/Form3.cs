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
    public partial class Form3 : Form
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

            
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide(); ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
