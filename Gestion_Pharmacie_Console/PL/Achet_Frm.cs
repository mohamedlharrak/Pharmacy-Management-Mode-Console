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
    public partial class Achet_Frm : Form
    {
        public Achet_Frm()
        {
            InitializeComponent();
        }

        private void Achet_Frm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtChifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConx_Click(object sender, EventArgs e)
        {
            string Reference = txtRef.Text;
            BL.Produit prodSearch = Main_Frm.ph.rechercherProduit(Reference);
            int chifa = Convert.ToInt32(txtChifa.Text);
            BL.Client clientSearch = Main_Frm.ph.rechercherClient(chifa);
            if (prodSearch != null && clientSearch!=null)
            {
                int qte = Convert.ToInt32(txtQte.Text);
                if (Main_Frm.ph.QuantiteOK(prodSearch, qte))
                {
                    Main_Frm.ph.Achat(clientSearch, prodSearch, qte);
                    MessageBox.Show("Achat effectué avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChifa.Text = "N° Chifa De Client";
                    txtRef.Text = "Referance De Produit";
                    txtQte.Text = "Quantité";
                }
                else
                {
                    MessageBox.Show("La quantité demandée n'est pas disponible","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                

            }
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            try
            {
                string Reference = txtRef.Text;
                BL.Produit prodSearch = Main_Frm.ph.rechercherProduit(Reference);
                if (prodSearch == null)
                {
                    DialogResult result = MessageBox.Show("Ce produit n'existe pas, pour annuler cette opération cliquer sur Yes", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result== DialogResult.Yes)
                    {
                        this.Hide();
                    }
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtChifa_Enter(object sender, EventArgs e)
        {
            if (txtChifa.Text == "N° Chifa De Client")
            {
                txtChifa.Text = "";
                txtChifa.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtRef_Enter(object sender, EventArgs e)
        {
            if (txtRef.Text == "Referance De Produit")
            {
                txtRef.Text = "";
                txtRef.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtChifa_Validated(object sender, EventArgs e)
        {
            try
            {
                int chifa = Convert.ToInt32(txtChifa.Text);
                BL.Client clientSearch = Main_Frm.ph.rechercherClient(chifa);
                if (clientSearch == null)
                {

                    DialogResult result = MessageBox.Show("Ce Client n'existe pas, Pour ajouter un client cliquer sur Yes", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        PL.Ad_Clients frm = new Ad_Clients();
                        frm.Show();
                        this.Hide();
                    }

                    txtChifa.Focus();
                    txtChifa.SelectionStart = 0;
                    txtChifa.SelectionLength = txtRef.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQte_Enter(object sender, EventArgs e)
        {
            if (txtQte.Text == "Quantité")
            {
                txtQte.Text = "";
                txtQte.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQte_Validated(object sender, EventArgs e)
        {

        }
    }
}
