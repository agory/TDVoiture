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
    public partial class FRestitution : Form
    {
        private Agence agence;
        private List<Voiture> voituresLouees = new List<Voiture>();
        public FRestitution(Agence agence)
        {
            InitializeComponent();
            lbl_loueur.Hide();
            this.agence = agence;

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cb_rendreVoiture.Items.Clear();
            List<Voiture> voitures = agence.ListeVoiture();
            voituresLouees.Clear();

            foreach (Voiture voiture in voitures)
            {
                if (voiture.EstLouee)
                {
                    voituresLouees.Add(voiture);
                    cb_rendreVoiture.Items.Add(voiture.Nom + " - " + voiture.Immatriculation);
                }
            }
            if (voituresLouees.Count == 0)
            {
                Close();
            }
            else
            {
                cb_rendreVoiture.SelectedIndex = 0;
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_valid_Click(object sender, EventArgs e)
        {
            foreach(Voiture voiture in voituresLouees)
            {
                if (voiture.Nom + " - " + voiture.Immatriculation == cb_rendreVoiture.SelectedItem.ToString())
                {
                    agence.RendreVoiture(voiture);
                    LoadComboBox();
                    break;
                }
            }
        }

        private void cb_rendreVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Voiture voiture in voituresLouees)
            {
                if(voiture.Nom + " - "+ voiture.Immatriculation == cb_rendreVoiture.SelectedItem.ToString())
                {
                    lbl_loueur.Show();
                    lbl_id_loueur.Text = voiture.Loueur.Nom + " " + voiture.Loueur.Prenom;
                }
            }
        }
    }
}
