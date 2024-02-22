using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_Pharmacie_Console.PL
{
    [Serializable]
    public partial class Main_Frm : Form
    {
       public static BL.Pharmacie ph = new BL.Pharmacie("Pharmacie AL CHIFA", "Reu d'Arabie Saoudite Tanger, Maroc.");
        public void Enregistrer()
        {
            FileStream fs = new FileStream("Pharmacie.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ph);
            fs.Close();
        }
        public BL.Pharmacie Ouvrire()
        {
            FileStream fs = new FileStream("Pharmacie.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            BL.Pharmacie l = (BL.Pharmacie)bf.Deserialize(fs);
            fs.Close();
            return l;
        }
        public Main_Frm()
        {
            InitializeComponent();
            
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {

        }

        private void btnProduitMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnProduitMenu.Top;
            PL.Frm_Produits frm = new PL.Frm_Produits();
            frm.Show();
        }

        private void btnCatMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnCatMenu.Top;
            PL.Client_Frm frm = new Client_Frm();
            frm.Show();
        }

        private void btnFourMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnFourMenu.Top;
            PL.Achet_Frm frm = new Achet_Frm();
            frm.Show();
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnUserMenu.Top;
            PL.Approvisionner_Frm frm = new Approvisionner_Frm();
            frm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 223)
            {
                panel1.Size = new Size(75, 537);
            }
            else
            {
                panel1.Size = new Size(223, 537);
            }
        }

        private void btnParametre_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            try
            {
                Main_Frm.ph = this.Ouvrire();
               // this.chargerData(this.lst);
            }
            catch (Exception err)
            {
                MessageBox.Show("Le fichier specifier n'existe pas", "Erreure", MessageBoxButtons.OK);
            }
            label1.Text = ph.Adresse;
            label2.Text = ph.Nom;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);

        }

        private void Main_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enregistrer();
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter", "Attantion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                
                e.Cancel = true;
            }

        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.About_Frm frm = new About_Frm();
            frm.Show();
        }

        private void ajouterUnNouveauProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Add_Prod frm = new Add_Prod();
            frm.Show();
        }

        private void gestionDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Frm_Produits frm = new PL.Frm_Produits();
            frm.Show();
        }

        private void acheterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Achet_Frm frm = new Achet_Frm();
            frm.Show();
        }

        private void approvisionnerLeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Approvisionner_Frm frm = new Approvisionner_Frm();
            frm.Show();
        }

        private void gestionDeCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Client_Frm frm = new Client_Frm();
            frm.Show();
        }

        private void ajouterUnNouveauCatégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Ad_Clients frm = new Ad_Clients();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
