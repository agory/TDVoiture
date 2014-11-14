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
    public partial class FAccueil : Form
    {
        private Personne unePersonne;
        private Agence agence;

        public FAccueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agence = new Agence();
        }

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutVoiture unAjoutV = new FAjoutVoiture();
            unAjoutV.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
