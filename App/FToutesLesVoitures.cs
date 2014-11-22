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

            CreerDgv();
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


                cbx_personne.Items.Add("AGENCE A3P");
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
                dgv_agence.Rows[i].Cells[0].Value = voiture.Nom.ToString();
                dgv_agence.Rows[i].Cells[1].Value = voiture.Immatriculation.ToString();
                dgv_agence.Rows[i].Cells[2].Value = voiture.Puissance.ToString();
                dgv_agence.Rows[i].Cells[3].Value = voiture.DateMiseService.ToString();
                dgv_agence.Rows[i].Cells[4].Value = voiture.EstLouee ? "Oui" : "Non";
                i++;
            }
        }

        private void RemplirDgvPersonneVoiture()
        {
            List<Voiture> voituresPersonnnes = new List<Voiture>();

            foreach (Voiture voiture in voitures)
            {
                if (cbx_personne.SelectedItem.ToString() == voiture.Loueur.Nom + " " + voiture.Loueur.Prenom)
                {
                    voituresPersonnnes.Add(voiture);
                }
            }

            dgv_agence.RowCount = voituresPersonnnes.Count;
            int i = 0;
            foreach (Voiture voiture in voituresPersonnnes)
            {
                dgv_agence.Rows[i].Cells[0].Value = voiture.Nom.ToString();
                dgv_agence.Rows[i].Cells[1].Value = voiture.Immatriculation.ToString();
                dgv_agence.Rows[i].Cells[2].Value = voiture.Puissance.ToString();
                dgv_agence.Rows[i].Cells[3].Value = voiture.DateMiseService.ToString();
                dgv_agence.Rows[i].Cells[4].Value = voiture.EstLouee ? "Oui" : "Non";
                i++;
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_personne_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemiseAZero();
            if (cbx_personne.SelectedItem.ToString() == "AGENCE A3P")
            {
                RemplirDgvVoiture();
            }
            else
            {
                RemplirDgvPersonneVoiture();
            }
        }

        private void RemiseAZero()
        {
            dgv_agence.Rows.Clear();
        }
        
    }
}
