using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Metier
{
    /// <summary>
    /// Classe Agence
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Agence", Namespace = "", IsNullable = false)]
    public class Agence
    {
        #region Propriétés privés de la classe
        private string nom;
        private List<Voiture> voitures;
        private List<Personne> personnes;
        #endregion

        #region Accesseur mutateur

        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [DataMember]
        [XmlArray("ParcVoiture")]
        [XmlArrayItem("Voiture", typeof(Voiture))]
        public List<Voiture> Voitures
        {
            get { return voitures; }
            set { voitures = value; }
        }

        [DataMember]
        [XmlArray("LesPersonnes")]
        [XmlArrayItem("Personne", typeof(Personne))]
        public List<Personne> Personnes
        {
            get { return personnes; }
            set { personnes = value; }
        }

        #endregion

        #region Constructeur init

        public Agence() { }

        public Agence(string nom)
        {
            this.nom = nom;
            this.personnes = new List<Personne>();
            this.voitures = new List<Voiture>();
        }

        #endregion

        #region Méthode

        public void AddPersonne(Personne personne)
        {
            this.personnes.Add(personne);
        }


        public void AddVoiture(Voiture voiture)
        {
            this.voitures.Add(voiture);
        }

        public void RemoveVoiture(Voiture voiture)
        {
            this.voitures.Remove(voiture);
        }

        public void RemovePersonne(Personne personne)
        {
            this.personnes.Remove(personne);
        }

        public List<Personne> ListePersonne()
        {
            return personnes;
        }

        public List<Voiture> ListeVoiture()
        {
            return voitures;
        }

        /// <summary>
        /// Loue une voiture
        /// </summary>
        /// <param name="voiture">La voiture à louée</param>
        /// <param name="personne">La personne qui loue la voiture</param>
        public void LouerVoiture(Voiture voiture, Personne personne)
        {
            voiture.Loueur = personne;
            voiture.EstLouee = true;
        }
        /// <summary>
        /// Rend une voiture
        /// </summary>
        /// <param name="voiture">La voiture rendue</param>
        public void RendreVoiture(Voiture voiture)
        {
            voiture.Loueur = null;
            voiture.EstLouee = false;
        }

        #endregion
        



        

       

        

    }
}
