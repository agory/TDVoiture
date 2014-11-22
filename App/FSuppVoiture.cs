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
        public FSuppVoiture(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            List<Voiture> voitures = agence.ListeVoiture();
            foreach(Voiture voiture in voitures){
                cb_voiture.Items.Add(voiture);
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {
            if (cb_voiture.SelectedItem.ToString() == "")
            {

            }
            else
            {
                cb_voiture.Items.Remove("");
            }

            Close();
        }
    }
}
