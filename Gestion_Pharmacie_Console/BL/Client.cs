using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie_Console.BL
{
    [Serializable]
    public class Client
    {
        private string nom;
        private string prenom;
        private int chifa;

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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public int Chifa
        {
            get
            {
                return chifa;
            }

            set
            {
                chifa = value;
            }
        }

        public Client(string nom, string prenom, int chifa)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.chifa = chifa;
        }
    }
}
