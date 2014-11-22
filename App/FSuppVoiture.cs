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
    public partial class FSuppVoiture : Form
    {
        private Agence agence;
        private List<Voiture> voitures = new List<Voiture>();
        public FSuppVoiture(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;

            LoadVoiture();
        }

        private void LoadVoiture()
        {
            cb_voiture.Items.Clear();
            voitures = agence.ListeVoiture();
            foreach (Voiture voiture in voitures)
            {
                cb_voiture.Items.Add(voiture.Nom + " - " + voiture.Immatriculation);
            }
            if (voitures.Count == 0)
                Close();
            else
            {
                cb_voiture.SelectedIndex = 0;
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {
            foreach(Voiture voiture in this.voitures)
            {
                //Try permettant de tester si la suppression d'un véhicule de l'agence est possible
                try
                {
                    if (cb_voiture.SelectedItem.ToString() == voiture.Nom + " - " + voiture.Immatriculation)
                    {
                        agence.RemoveVoiture(voiture);
                        //MessageBox.Show("La " + voiture.Nom + " ayant l'immatriculation " + voiture.Immatriculation + " a été supprimée de l'agence");
                        LoadVoiture();
                        break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
