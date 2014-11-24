using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    [Serializable]
    public class Voiture
    {

        #region Propriétés privés de la classe

        private string categorie;
        private string immatriculation;
        private string nom;
        private int puissance;
        private DateTime dateMiseService;
        private bool estLouee;
        private Personne loueur;

        #endregion

        #region Accesseur mutateur

        public Personne Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }


        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public DateTime DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        #endregion

        #region Constructeur init

        public Voiture()
        {

        }
        public Voiture(string categorie, string immatriculation, string nom, int puissance, DateTime dateMiseService)
        {
            this.categorie = categorie;
            this.immatriculation = immatriculation;
            this.nom = nom;
            this.puissance = puissance;
            this.dateMiseService = dateMiseService;
        }

        #endregion

        #region Méthode
        #endregion
        

        
    }
}
