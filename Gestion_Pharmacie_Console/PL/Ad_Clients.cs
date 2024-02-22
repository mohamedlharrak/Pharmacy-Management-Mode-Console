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
    public partial class Ad_Clients : Form
    {
        public Ad_Clients()
        {
            InitializeComponent();
        }

        private void txtChifa_Enter(object sender, EventArgs e)
        {
            if (txtChifa.Text == "N° Chifa")
            {
                txtChifa.Text = "";
                txtChifa.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prénom")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int chifa = Convert.ToInt32(txtChifa.Text);
                BL.Client prodSearch = Main_Frm.ph.rechercherClient(chifa);
                if (prodSearch == null)
                {
                    string nom = txtNom.Text;
                    string prenom = txtPrenom.Text;
                    BL.Client c = new BL.Client(nom, prenom, chifa);
                    Main_Frm.ph.AjouterClient(c);
                    MessageBox.Show("Produit ajouter avec succès !", "Informaton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChifa.Text= "N° Chifa";
                    txtPrenom.Text = "Nom";
                    txtNom.Text = "Prénom";
                }
                else
                {
                    MessageBox.Show("ce client exest diga !", "atantion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChifa.Focus();
                    txtChifa.SelectionStart = 0;
                    txtChifa.SelectionLength = txtChifa.TextLength;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtChifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Client_Frm frm = new Client_Frm();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
