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
    public partial class FSuppVoiture : Form
    {
        private Agence agence;
        public FSuppVoiture(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
