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
    public partial class FormaPrincipala : Form
    {
        public FormaPrincipala()
        {
            InitializeComponent();
        }

        private void FormaPrincipala_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-0AN6M9A;Initial Catalog=HaineMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from Haine";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds=new DataSet();
            da.Fill(ds, "Haine");
            dataGridViewHaine.DataSource = ds.Tables["Haine"].DefaultView;
            conn.Close();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-0AN6M9A;Initial Catalog=HaineMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            if(txtCautare.Text!=string.Empty)
            {
                string tabel_date = "select * from Haine where tip_produs='" + txtCautare.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Haine");
                dataGridViewHaine.DataSource = ds.Tables["Haine"].DefaultView;
                conn.Close();
            }
            else
            {
                string tabel_date = "select * from Haine ";
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Haine");
                dataGridViewHaine.DataSource = ds.Tables["Haine"].DefaultView;
                conn.Close();
            }
        }

        private void adaugareHaina_Click(object sender, EventArgs e)
        {
            AdaugareProdus f = new AdaugareProdus();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-0AN6M9A;Initial Catalog=HaineMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string stergere = "delete from Haine where id='" + txtStergere.Text + "'";
            SqlCommand st = new SqlCommand(stergere, conn);
            DataSet ds = new DataSet();
            st.Parameters.AddWithValue("@id", txtStergere.Text);
            st.ExecuteNonQuery();
            conn.Close();

            string refreshQuery = "SELECT * FROM Haine";
            SqlDataAdapter de = new SqlDataAdapter(refreshQuery, connect);
            DataSet dg = new DataSet();
            de.Fill(dg, "Haine");
            dataGridViewHaine.DataSource = dg.Tables["Haine"].DefaultView;
        }
    }
}
