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
    public partial class FSuppPersonne : Form
    {
        private Agence agence;
        private List<Personne> personnes;
        public FSuppPersonne(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            personnes = agence.ListePersonne();

            foreach (Personne personne in personnes)
            {
                cb_personne.Items.Add(personne.Nom + " " + personne.Prenom + " - " + personne.Ville);
            }
            cb_personne.SelectedIndex = 0;
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {
            //Try permettant de tester si la suppression d'une personne de l'agence est possible
            try
            {
                foreach (Personne personne in personnes)
                {
                    //string[] split = cb_personne.SelectedItem.ToString().Split(new String[] { " ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                    if (cb_personne.SelectedItem.ToString() == personne.Nom + " " + personne.Prenom + " - " + personne.Ville)
                    {
                        agence.RemovePersonne(personne);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }
    }
}
