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
    public partial class FToutesLesVoitures : Form
    {
        private Agence agence;
        private List<Voiture> voitures;
        private List<Personne> personnes;

        public FToutesLesVoitures(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            voitures = agence.ListeVoiture();
            personnes = agence.ListePersonne();
            string listeCateg = "";
            cbx_trie.Items.Add("Tout");

            foreach(Voiture voiture in voitures)
            {
                if (!listeCateg.Contains(voiture.Categorie))
                {
                    listeCateg += voiture.Categorie;
                    cbx_trie.Items.Add(voiture.Categorie);
                }
            }

            CreerDgv();
             RemplirDgvPersonneVoiture();
        }

        private void CreerDgv()
        {
            try
            {
                List<String> nomsHeaderCell = new List<String>();
                nomsHeaderCell.Add("Nom");
                nomsHeaderCell.Add("Immatriculation");
                nomsHeaderCell.Add("Puissance");
                nomsHeaderCell.Add("Date de mise en service");
                nomsHeaderCell.Add("Louée");
                dgv_agence.RowHeadersWidth += 95;
                dgv_agence.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgv_agence.ColumnCount = nomsHeaderCell.Count;
                for (int i = 0; i < dgv_agence.ColumnCount; i++)
                {
                    dgv_agence.Columns[i].HeaderCell.Value = nomsHeaderCell[i];
                }


                cbx_trie.SelectedIndex = 0;
                cbx_personne.Items.Add("Tout");
                cbx_personne.SelectedIndex = 0;

                RemplirDgvPersonne();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void RemplirDgvPersonne()
        {
            foreach(Personne personne in personnes)
            {
                cbx_personne.Items.Add(personne.Nom + " " + personne.Prenom);
            }
        }

        private void RemplirDgvVoiture()
        {
            dgv_agence.RowCount = agence.ListeVoiture().Count;
            int i = 0;
            foreach (Voiture voiture in voitures)
            {
                if (voiture.Categorie == cbx_trie.SelectedItem.ToString())
                {
                    dgv_agence.Rows[i].Cells[0].Value = voiture.Nom.ToString();
                    dgv_agence.Rows[i].Cells[1].Value = voiture.Immatriculation.ToString();
                    dgv_agence.Rows[i].Cells[2].Value = voiture.Puissance.ToString();
                    dgv_agence.Rows[i].Cells[3].Value = voiture.DateMiseService.ToString();
                    dgv_agence.Rows[i].Cells[4].Value = voiture.EstLouee ? "Oui" : "Non";
                    i++;
                }
            }
        }
        private List<Voiture> TriVoiture() {
            List<Voiture> voituresDGV = new List<Voiture>();

            foreach (Voiture voiture in voitures)
            {
                if ((cbx_personne.Text == voiture.getNameLoueur()
                    || cbx_personne.Text == "Tout")
                    &&
                    (cbx_trie.Text == voiture.Categorie
                    || cbx_trie.Text == "Tout"))
                {
                    voituresDGV.Add(voiture);
                }
            }

            return voituresDGV;
        }

        private void RemplirDgvPersonneVoiture()
        {
            List<Voiture> voituresDGV = TriVoiture();
            if (voituresDGV.Count > 0)
            {
                dgv_agence.RowCount = voituresDGV.Count;
                int i = 0;
                foreach (Voiture voiture in voituresDGV)
                {
                    dgv_agence.Rows[i].Cells[0].Value = voiture.Nom.ToString();
                    dgv_agence.Rows[i].Cells[1].Value = voiture.Immatriculation.ToString();
                    dgv_agence.Rows[i].Cells[2].Value = voiture.Puissance.ToString();
                    dgv_agence.Rows[i].Cells[3].Value = voiture.DateMiseService.ToString();
                    dgv_agence.Rows[i].Cells[4].Value = voiture.EstLouee ? "Oui" : "Non";
                    i++;
                }
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_personne_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemiseAZero();
            RemplirDgvPersonneVoiture();
        }

        private void RemiseAZero()
        {
            dgv_agence.Rows.Clear();
        }

        private void cbx_trie_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemiseAZero();
            RemplirDgvPersonneVoiture();
        }
        
    }
}
