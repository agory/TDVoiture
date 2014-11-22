using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace App
{
    public partial class FLocation : Form
    {
        private Agence agence;
        private List<Voiture> voituresNonLoue;
        private List<Personne> personnes;
        public FLocation(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            LoadLocation();
            cb_voiture.SelectedIndex = 0;
            cb_personne.SelectedIndex = 0;
        }

        private void LoadLocation()
        {
            List<Voiture> voitures = agence.ListeVoiture();
            voituresNonLoue = new List<Voiture>();

            foreach (Voiture voiture in voitures)
            {
                if (!voiture.EstLouee)
                { 
                    voituresNonLoue.Add(voiture);
                    cb_voiture.Items.Add(voiture.Nom + " - " + voiture.Immatriculation);
                }
            }

            personnes = agence.ListePersonne();
            foreach (Personne personne in personnes)
            {
                cb_personne.Items.Add(personne.Nom + " " + personne.Prenom + " - " + personne.Ville);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_valid_Click(object sender, EventArgs e)
        {
            foreach(Personne personne in personnes)
            {
                if(personne.Nom + " " + personne.Prenom + " - " + personne.Ville == cb_personne.SelectedItem.ToString())
                {
                    foreach (Voiture voiture in voituresNonLoue)
                    {
                        if (voiture.Nom + " - " + voiture.Immatriculation == cb_voiture.SelectedItem.ToString())
                        {
                            agence.LouerVoiture(voiture, personne);
                            Close();
                        }
                    }
                }
            }
            
        }
    }
}
