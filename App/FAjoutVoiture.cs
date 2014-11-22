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
    public partial class FAjoutVoiture : Form
    {
        private Voiture voiture;
        private Agence agence;

        public FAjoutVoiture(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            voiture = new Voiture();
            cbx_categorie.SelectedIndex = 0;
        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            LoadCar();
        }

        public void LoadCar()
        {
            try
            {
                if(tb_voiture.Text == "" || tb_puissance.Text  == "" || tb_immat.Text  == "" || tb_date.Text  == "" || tb_immat.Text  == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
                else
                {
                    voiture.Categorie = cbx_categorie.Text;
                    voiture.DateMiseService = Convert.ToDateTime(tb_date.Text);
                    voiture.Immatriculation = tb_immat.Text;
                    voiture.Nom = tb_voiture.Text;
                    voiture.Puissance = Convert.ToInt32(tb_puissance.Text);

                    this.agence.AddVoiture(voiture);
                    this.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                //TODO
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
