using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Personne
    {
        private string nom;
        private string prenom;
        private string ville;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

    }
}
