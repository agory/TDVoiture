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

        public FAjoutVoiture(Voiture voiture)
        {
            InitializeComponent();
            this.voiture = voiture;
            LoadCar();
        }

        public void LoadCar()
        {
            try
            {
                voiture.Categorie = cbx_categorie.SelectedValue.ToString();
                voiture.DateMiseService = Convert.ToDateTime(tb_date.Text);
                voiture.Immatriculation = tb_immat.Text;
                voiture.Nom = tb_voiture.Text;
                voiture.Puissance = Convert.ToInt32(tb_puissance.Text);
            }
            catch(Exception e)
            {
                //TODO
            }
        }
    }
}
