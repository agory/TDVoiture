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
    public partial class FToutesLesPersonnes : Form
    {
        private Agence agence;
        public FToutesLesPersonnes(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            CrerDgv();
        }

        private void CrerDgv()
        {
            try
            {
                List<String> nomsHeaderCell = new List<String>();
                nomsHeaderCell.Add("Nom");
                nomsHeaderCell.Add("Prénom");
                nomsHeaderCell.Add("Ville");
                dgv_personne.RowHeadersWidth += 95;
                dgv_personne.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgv_personne.RowCount = agence.ListePersonne().Count;
                dgv_personne.ColumnCount = nomsHeaderCell.Count;
                for (int i = 0; i < dgv_personne.ColumnCount; i++)
                {
                    dgv_personne.Columns[i].HeaderCell.Value = nomsHeaderCell[i];
                }

                RemplirDgv();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void RemplirDgv()
        {
            List<Personne> personnes = this.agence.ListePersonne();
            int i = 0;
            foreach (Personne personne in personnes)
            {
                dgv_personne.Rows[i].Cells[0].Value = personne.Nom.ToString();
                dgv_personne.Rows[i].Cells[1].Value = personne.Prenom.ToString();
                dgv_personne.Rows[i].Cells[2].Value = personne.Ville.ToString();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
