using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    [Serializable]
    public class Agence
    {

        private string nom;
        private List<Voiture> voitures;
        private List<Personne> personnes;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Agence() { }

        public Agence(string nom)
        {
            this.nom = nom;
            this.personnes = new List<Personne>();
            this.voitures = new List<Voiture>();
        }

        public void AddPersonne(Personne personne) {
            this.personnes.Add(personne); 
        }

        
        public void AddVoiture(Voiture voiture)
        {
            this.voitures.Add(voiture);
        }

        public void RemoveVoiture(Voiture voiture) {
            this.voitures.Remove(voiture);
        }

        public void RemovePersonne(Personne personne) {
            this.personnes.Remove(personne);
        }

        public List<Personne> ListePersonne() {
            return personnes;
        }

        public List<Voiture> ListeVoiture()
        {
            return voiture;
        }
    }
}
