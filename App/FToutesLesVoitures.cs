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

        public FToutesLesVoitures(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            CreerDgv();
        }

        public void CreerDgv()
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
                dgv_agence.RowCount = agence.ListeVoiture().Count;
                dgv_agence.ColumnCount = nomsHeaderCell.Count;
                for (int i = 0; i < dgv_agence.ColumnCount; i++)
                {
                    dgv_agence.Columns[i].HeaderCell.Value = nomsHeaderCell[i];
                }

                RemplirDgv();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void RemplirDgv()
        {
            List<Voiture> mesVoitures = this.agence.ListeVoiture();
            int i = 0;
            foreach(Voiture voiture in mesVoitures)
            {
                dgv_agence.Rows[i].Cells[0].Value = voiture.Nom.ToString();
                dgv_agence.Rows[i].Cells[1].Value = voiture.Immatriculation.ToString();
                dgv_agence.Rows[i].Cells[2].Value = voiture.Puissance.ToString();
                dgv_agence.Rows[i].Cells[3].Value = voiture.DateMiseService.ToString();
                dgv_agence.Rows[i].Cells[4].Value = voiture.Nom.ToString();
                i++;
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
