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
    public partial class FSuppPersonne : Form
    {
        private Agence agence;
        public FSuppPersonne(Agence agence)
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
