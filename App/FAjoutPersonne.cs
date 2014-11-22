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
    public partial class FAjoutPersonne : Form
    {
        private Personne personne;
        private Agence agence;

        public FAjoutPersonne(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            personne = new Personne();

        }
        public void LoadPersonne()
        {
            try
            {
                if(tb_nom.Text == "" || tb_prenom.Text == "" || tb_ville.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
                else
                {
                    personne.Nom = tb_nom.Text;
                    personne.Prenom = tb_prenom.Text;
                    personne.Ville = tb_ville.Text;

                    agence.AddPersonne(personne);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_valid_Click(object sender, EventArgs e)
        {
            LoadPersonne();
        }
    }
}
