using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestionare_produse
{
    public partial class AdaugareProdus : Form
    {
        public AdaugareProdus()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(txtID.Text!=string.Empty && txtTP.Text!=string.Empty && txtR.Text!= string.Empty && txtPr.Text != string.Empty && txtAn.Text != string.Empty && txtProd.Text != string.Empty)
            {
                string connect = @"Data Source=DESKTOP-0AN6M9A;Initial Catalog=HaineMagazin; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into Haine([id],[tip_produs],[raion],[pret],[an_colectie],[producator]) values (@id, @tp, @r, @p, @a, @pr)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
                sc.Parameters.AddWithValue("@tp",txtTP.Text);
                sc.Parameters.AddWithValue("@r", txtR.Text);
                sc.Parameters.AddWithValue("@p", Convert.ToDecimal(txtPr.Text)); // Convertit la decimal pentru pret
                sc.Parameters.AddWithValue("@a", Convert.ToInt32(txtAn.Text)); // Convertit la int pentru an_colectie
                sc.Parameters.AddWithValue("@pr", txtProd.Text);
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Trebuie completate toate campurile");
            }
        }

        private void AdaugareProdus_Load(object sender, EventArgs e)
        {

        }
    }
}
