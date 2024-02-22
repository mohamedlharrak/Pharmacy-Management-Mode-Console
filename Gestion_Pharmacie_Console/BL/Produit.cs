using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie_Console.BL
{
    [Serializable]
    public class Produit
    {
        private string reference;
        private double prix;
        private int qte;

        public string Reference
        {
            get
            {
                return reference;
            }

            set
            {
                reference = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public int Qte
        {
            get
            {
                return qte;
            }

            set
            {
                qte = value;
            }
        }

        public Produit(string reference, double prix, int qte)
        {
            this.reference = reference;
            this.prix = prix;
            this.qte = qte;
        }
    }
}
