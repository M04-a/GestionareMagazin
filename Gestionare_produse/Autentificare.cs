using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestionare_produse
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("Utilizatori.txt");
            foreach(var linie in utilizatori)
            {
                string[] inregistrare = linie.Split(',');
                textNume.Items.Add(inregistrare[0]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int inc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("Utilizatori.txt");
            foreach (var linie in utilizatori)
            {
                string[] inregistrare = linie.Split(',');
                if (textNume.Text.Equals(inregistrare[0]))
                {
                    if (textParola.Text.Trim().Equals(inregistrare[1].Trim()))
                    {
                        FormaPrincipala f = new FormaPrincipala();
                        f.ShowDialog();
                    }
                    else
                    {
                        inc++;
                        MessageBox.Show("Parola este incorecta. Mai aveti " + (3 - inc) + " incercari");
                    }
                }
                if(inc==3)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_inreg_Click(object sender, EventArgs e)
        {
            Inregistrare inregistrare = new Inregistrare(); 
            inregistrare.ShowDialog();
        }
    }
}
