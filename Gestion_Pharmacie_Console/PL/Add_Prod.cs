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
    public partial class Add_Prod : Form
    {
        
        public Add_Prod()
        {
            InitializeComponent();
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRef_Enter(object sender, EventArgs e)
        {
            if (txtRef.Text == "Referance")
            {
                txtRef.Text = "";
                txtRef.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            if (txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.WhiteSmoke;
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

        private void Add_Prod_Load(object sender, EventArgs e)
        {
            this.cmbMedi.Enabled = false;
            this.cmbParaPhar.Enabled = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbParaPhar.Enabled = true;
            this.cmbMedi.Enabled = false;
            cmbMedi.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbParaPhar.Enabled = false;
            this.cmbMedi.Enabled = true;
            cmbParaPhar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Frm_Produits frm = new Frm_Produits();
            frm.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Ref = txtRef.Text;
                BL.Produit prodSearch = Main_Frm.ph.rechercherProduit(Ref);
                if (prodSearch == null)
                {
                    double prixProd = Convert.ToDouble(txtPrix.Text);
                    int qteProd = int.Parse(txtQte.Text);

                    if (cmbParaPhar.SelectedIndex == cmbParaPhar.FindStringExact("Beauté"))
                    {
                        BL.ProdParPharm p = new BL.ProdParPharm(Ref, prixProd, qteProd, "Beauté");
                        Main_Frm.ph.AjouterProduit(p);
                    }
                    if (cmbParaPhar.SelectedIndex == cmbParaPhar.FindStringExact("Cosmétiqeu"))
                    {
                        BL.ProdParPharm p = new BL.ProdParPharm(Ref, prixProd, qteProd, "Cosmétiqeu");
                        Main_Frm.ph.AjouterProduit(p);
                    }
                    if (cmbParaPhar.SelectedIndex == cmbParaPhar.FindStringExact("Diététique"))
                    {
                        BL.ProdParPharm p = new BL.ProdParPharm(Ref, prixProd, qteProd, "Diététique");
                        Main_Frm.ph.AjouterProduit(p);
                    }
                    if (cmbMedi.SelectedIndex == cmbMedi.FindStringExact("Generique"))
                    {
                        BL.Medicament p = new BL.Medicament(Ref, prixProd, qteProd, true, false);
                        Main_Frm.ph.AjouterProduit(p);
                    }
                    if (cmbMedi.SelectedIndex == cmbMedi.FindStringExact("Ordannace"))
                    {
                        BL.Medicament p = new BL.Medicament(Ref, prixProd, qteProd, false, true);
                        Main_Frm.ph.AjouterProduit(p);
                    }
                    MessageBox.Show("Produit ajouter avec succès !", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRef.Text="Referance";
                    txtPrix.Text = "Prix";
                    txtQte.Text = "Quantité";
                    cmbMedi.Text = "";
                    cmbParaPhar.Text = "";

                }
                else
                {
                    MessageBox.Show("ce produit exest diga !", "atantion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
