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
    public partial class Approvisionner_Frm : Form
    {
        public Approvisionner_Frm()
        {
            InitializeComponent();
        }

        private void txtRef_Enter(object sender, EventArgs e)
        {
            if (txtRef.Text == "Referance De Produit")
            {
                txtRef.Text = "";
                txtRef.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtQte_Enter(object sender, EventArgs e)
        {
            if (txtQte.Text == "Quantité")
            {
                txtQte.Text = "";
                txtQte.ForeColor = Color.WhiteSmoke;
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
                    if (result == DialogResult.Yes)
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

        private void btnConx_Click(object sender, EventArgs e)
        {
            string Reference = txtRef.Text;
            BL.Produit prodSearch = Main_Frm.ph.rechercherProduit(Reference);
            int qte = Convert.ToInt32(txtQte.Text);
            if (prodSearch != null)
            {
                Main_Frm.ph.Approvisionner(prodSearch, qte);
                MessageBox.Show("Approvisionner effectué avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRef.Text = "Referance De Produit";
                txtQte.Text = "Quantité";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
