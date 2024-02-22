using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie_Console.BL
{
    [Serializable]
    public class ProdParPharm : Produit
    {
        private string type;

        public ProdParPharm(string reference, double prix, int qte, string type) : base(reference, prix, qte)
        {
            this.type = type;
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        
        
    }
}
