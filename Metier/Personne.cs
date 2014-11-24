using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    [Serializable]
    public class Personne
    {
        #region Propriétés privés de la classe

        private string nom;
        private string prenom;
        private string ville;

        #endregion

        #region Accesseur mutateur

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

        #endregion

        #region Constructeur init

        public Personne() { }
        public Personne(string nom, string prenom, string ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }

        #endregion

        #region Méthode
        #endregion

        

        

        

    }
}
