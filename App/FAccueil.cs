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
        private Agence agence;

        public FAccueil()
        {
            InitializeComponent();
            this.agence = new Agence("Agence A3P");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FToutesLesVoitures toutesVoit = new FToutesLesVoitures(agence);
            toutesVoit.ShowDialog();
        }

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutVoiture unAjoutV = new FAjoutVoiture(agence);
            unAjoutV.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSuppVoiture uneSuppV = new FSuppVoiture(agence);
            uneSuppV.ShowDialog();
        }

        private void ajouterUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FAjoutPersonne unAjoutP = new FAjoutPersonne(agence);
            unAjoutP.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FSuppPersonne uneSuppP = new FSuppPersonne(agence);
            uneSuppP.ShowDialog();
        }

        private void louerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLocation uneLocation = new FLocation(agence);
            uneLocation.ShowDialog();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRestitution uneRestitution = new FRestitution(agence);
            uneRestitution.ShowDialog();
        }

        private void toutesLesVoituresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FToutesLesVoitures toutesVoitures = new FToutesLesVoitures(agence);
            toutesVoitures.ShowDialog();
        }
    }
}
