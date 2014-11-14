using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Voiture
    {
        private string categorie;
        private string immatriculation;
        private string loueur;
        private string nom;
        private int puissance;
        private DateTime dateMiseService;

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
        private bool estLoue;

        public string Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public bool EstLoue
        {
            get { return estLoue; }
            set { estLoue = value; }
        }
        public Voiture()
        {

        }
        public Voiture(string categorie, string immatriculation, string loueur, string nom, int puissance, DateTime dateMiseService)
        {
            this.categorie = categorie;
            this.immatriculation = immatriculation;
            this.loueur = loueur;
            this.nom = nom;
            this.puissance = puissance;
            this.dateMiseService = dateMiseService;
        }
    }
}
