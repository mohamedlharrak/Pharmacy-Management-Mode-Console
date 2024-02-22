using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_Console.PL
{
    [Serializable]
    public partial class Client_Frm : Form
    {
        public Client_Frm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Ad_Clients frm = new Ad_Clients();
            frm.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Rechercher")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.WhiteSmoke;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Client_Frm_Load(object sender, EventArgs e)
        {
            this.chargerData();
        }
        public void chargerData()
        {

            dataGridView1.Rows.Clear();
            foreach (BL.Client c in Main_Frm.ph.Clients1)
            {
                if (c != null)
                {
                    DataGridViewRow ligne = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    ligne.Cells[0].Value = c.Chifa;
                    ligne.Cells[1].Value = c.Nom;
                    ligne.Cells[2].Value = c.Prenom;
                    dataGridView1.Rows.Add(ligne);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
