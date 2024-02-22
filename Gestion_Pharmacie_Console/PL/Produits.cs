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
    public partial class Frm_Produits : Form
    {
        
        public Frm_Produits()
        {
            InitializeComponent();
          
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Rechercher")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.WhiteSmoke;
            }
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (BL.Produit P in Main_Frm.ph.Produits1)
            {
                if (P != null && P is BL.ProdParPharm)
                {
                    DataGridViewRow ligne = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    ligne.Cells[0].Value = P.Reference;
                    ligne.Cells[1].Value = P.Prix;
                    ligne.Cells[2].Value = P.Qte;
                    ligne.Cells[3].Value = ((BL.ProdParPharm)P).Type;
                    dataGridView1.Rows.Add(ligne);
                }
            }

        }

        private void Frm_Produits_Load(object sender, EventArgs e)
        {
            this.chargerData();
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.chargerData();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Add_Prod frm = new Add_Prod();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            foreach (BL.ProdParPharm pa in Main_Frm.ph.Produits1)
            {

                this.dataGridView1.Rows.Add(pa.Reference.ToString(), Convert.ToString(pa.Prix).ToString(), Convert.ToString(pa.Qte).ToString());
            }
           

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (BL.Produit P in Main_Frm.ph.Produits1)
            {
                if (P != null && P is BL.Medicament)
                {
                    DataGridViewRow ligne = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    ligne.Cells[0].Value = P.Reference;
                    ligne.Cells[1].Value = P.Prix;
                    ligne.Cells[2].Value = P.Qte;
                    ligne.Cells[3].Value = "-";
                    ligne.Cells[4].Value = ((BL.Medicament)P).gen;
                    ligne.Cells[5].Value = ((BL.Medicament)P).ord;
                    dataGridView1.Rows.Add(ligne);
                }
            }
        }

        public void chargerData()
        {

            dataGridView1.Rows.Clear();
            foreach (BL.Produit P in Main_Frm.ph.Produits1)
            {
                if (P != null)
                {
                    DataGridViewRow ligne = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    ligne.Cells[0].Value = P.Reference;
                    ligne.Cells[1].Value = P.Prix;
                    ligne.Cells[2].Value = P.Qte;

                    if (P is BL.Medicament)
                    {
                        ligne.Cells[3].Value = "-";
                        ligne.Cells[4].Value = ((BL.Medicament)P).gen;
                        ligne.Cells[5].Value = ((BL.Medicament)P).ord;
                    }

                    if (P is BL.ProdParPharm)
                    {
                        //ligne.Cells[3].Value = "Produit Para";
                        ligne.Cells[3].Value = ((BL.ProdParPharm)P).Type;
                    }

                    dataGridView1.Rows.Add(ligne);
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                BL.Produit prod = Main_Frm.ph.rechercherProduit(txtID.Text);

                if (prod != null)
                {
                    DataGridViewRow ligne = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    ligne.Cells[0].Value = prod.Reference;
                    ligne.Cells[1].Value = prod.Prix;
                    ligne.Cells[2].Value = prod.Qte;

                    if (prod is BL.Medicament)
                    {
                        ligne.Cells[3].Value = "-";
                        ligne.Cells[4].Value = ((BL.Medicament)prod).gen;
                        ligne.Cells[5].Value = ((BL.Medicament)prod).ord;
                    }

                    if (prod is BL.ProdParPharm)
                    {
                        //ligne.Cells[3].Value = "Produit Para";
                        ligne.Cells[3].Value = ((BL.ProdParPharm)prod).Type;
                    }

                    dataGridView1.Rows.Add(ligne);
                }
            }
            catch
            {
                MessageBox.Show("ce prodtuit ne exist pas");
            }
        }
    }
}
