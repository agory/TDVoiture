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
            Load();
        }

        public void Load()
        {
            List<String> nomsHeaderCell = new List<String>();
            nomsHeaderCell.Add("Nom");
            nomsHeaderCell.Add("Immatriculation");
            nomsHeaderCell.Add("Puissance");
            nomsHeaderCell.Add("Date de mise en service");
            nomsHeaderCell.Add("Louée");

            CreerDgv(nomsHeaderCell);
        }

        public void CreerDgv(List<String> nomsHeaderCell)
        {
            try
            {
                dgv_agence.RowHeadersWidth += 95;
                dgv_agence.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgv_agence.RowCount = agence.Voitures.Count;
                dgv_agence.ColumnCount = nomsHeaderCell.Count;
                for (int i = 0; i < dgv_agence.ColumnCount; i++)
                {
                    dgv_agence.Columns[i].HeaderCell.Value = nomsHeaderCell[i];
                }

                for (int i = 0; i < nb; i++)
                {
                    dgv_agence.Rows[i].HeaderCell.Value = text + " " + i;
                }
                RemplirDgv(nom);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
    }
}
