using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Agence
    {
        private int yala;
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Agence(string nom)
        {
            this.nom = nom;
        }

    }
}
