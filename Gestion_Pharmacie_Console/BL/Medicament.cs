using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie_Console.BL
{
    [Serializable]
    public class Medicament : Produit
    {
        private bool generique;
        private bool ordonnance;
        public string gen = "Non", ord = "Non";
        public Medicament(string reference, double prix, int qte, bool generique, bool ordonnance) : base(reference, prix, qte)
        {
            this.generique = generique;
            this.ordonnance = ordonnance;
            
            if (this.generique)
                gen = "Oui";
            if (this.ordonnance)
                ord = "Oui";
        }

        public bool Generique
        {
            get
            {
                return generique;
            }

            set
            {
                generique = value;
            }
        }

        public bool Ordonnance
        {
            get
            {
                return ordonnance;
            }

            set
            {
                ordonnance = value;
            }
        }
    }
}
