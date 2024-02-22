using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie_Console.BL
{
    [Serializable]
    public class Pharmacie
    {
     
        private string nom;
        private string adresse;
        private List<Client> clients=new List<Client>();
        private List<Produit> produits = new List<Produit>();
        
        

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }
        public List<Client> Clients1 { get => clients; set => clients = value; }
        public List<Produit> Produits1 { get => produits; set => produits = value; }

        public Pharmacie(string nom, string adresse)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.Clients1 = new List<Client>();
            this.Produits1 = new List<Produit>();
        }
        public void Achat(Client c, Produit p, int qte)
        {
            Produit posProduit = rechercherProduit(p.Reference);
            if (posProduit != null)
            {
                posProduit.Qte -= qte;
            }
        }

        public Client rechercherClient(int chifa)
        {

            foreach (Client c in this.clients)
                if (c.Chifa == chifa)
                    return c;
            return null;
        }

        public Produit rechercherProduit(string reference)
        {
            foreach (Produit p in this.produits)
                if (p.Reference == reference)
                    return p;
            return null;
        }

        

        public void Approvisionner(Produit p, int qte)
        {
            Produit posProduit = rechercherProduit(p.Reference);
            if (posProduit != null)
                posProduit.Qte += qte;
        }

        public void AjouterClient(Client c)
        {
            this.clients.Add(c);
        }

        public void AjouterProduit(Produit p)
        {
            this.Produits1.Add(p);
        }
        public bool QuantiteOK(Produit p, int qteDemande)
        {
            if (p.Qte >= qteDemande)
                return true;
            return false;
        }
    }
}
