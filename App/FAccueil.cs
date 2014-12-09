using Metier;
using Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace App
{
    public partial class FAccueil : Form
    {
        protected Agence agence;

        public FAccueil()
        {
            InitializeComponent();
            this.agence = new Agence("Agence A3P");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Voiture
        private void ajouterUneVoiture_Click(object sender, EventArgs e)
        {
            FAjoutVoiture unAjoutV = new FAjoutVoiture(agence);
            unAjoutV.ShowDialog();
        }

        private void supprimerUneVoiture_Click(object sender, EventArgs e)
        {


            if (testVoiture())
            {
                FSuppVoiture uneSuppV = new FSuppVoiture(agence);
                uneSuppV.ShowDialog();
            }
            else
            {
                erreur("voiture");
            }
        }
        private void toutesLesVoitures_Click(object sender, EventArgs e)
        {
            if (testVoiture())
            {
                FToutesLesVoitures toutesVoit = new FToutesLesVoitures(agence);
                toutesVoit.ShowDialog();
            }
            else
            {
                erreur("voiture");
            }
        }
        #endregion

        #region Personne
        private void ajouterUnePersonne_Click(object sender, EventArgs e)
        {

            FAjoutPersonne unAjoutP = new FAjoutPersonne(agence);
            unAjoutP.ShowDialog();
        }

        private void supprimerUnePersonne_Click(object sender, EventArgs e)
        {
            if (testPersonne())
            {
                FSuppPersonne uneSuppP = new FSuppPersonne(agence);
                uneSuppP.ShowDialog();
            }
            else
            {
                erreur("personne");
            }
        }
        private void toutesLesPersonnes_Click(object sender, EventArgs e)
        {
            if (testPersonne())
            {
                FToutesLesPersonnes toutesPersonnes = new FToutesLesPersonnes(agence);
                toutesPersonnes.ShowDialog();
            }
            else
            {
                erreur("personne");
            }
        }
        #endregion Personne

        #region Location
        private void louerUneVoiture_Click(object sender, EventArgs e)
        {
            if (testVoiture())
            {
                if(testPersonne())
                { 
                    if(testToutesVoituresLouees())
                    {
                        FLocation uneLocation = new FLocation(agence);
                        uneLocation.ShowDialog();
                    }
                    else
                    {
                        erreur("");
                    }
                }
                else
                {
                    erreur("personne");
                }
            }
            else
            {
                erreur("voiture");
            }
        }

        private void rendreUneVoiture_Click(object sender, EventArgs e)
        {
            if (testVoiture())
            {
                if(testPersonne())
                {
                    if(testVoitureLouee())
                    {
                        FRestitution unerestitution = new FRestitution(agence);
                        unerestitution.ShowDialog();
                    }
                    else
                    {
                        erreur("voiture louée");
                    }
                }
                else
                {
                    erreur("personne");
                }
            }
            else
            {
                erreur("voiture");
            }
        }

        #endregion
        
        #region Test

        private bool testVoiture()
        {
            if (agence.ListeVoiture().Count != 0)
                return true;
            else
                return false;
        }

        private bool testPersonne()
        {
            if (agence.ListePersonne().Count != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Fonction permettant de déterminer si au moins une voiture est louée
        /// </summary>
        private bool testVoitureLouee()
        {
            List<Voiture> voitures = agence.ListeVoiture();
            foreach(Voiture voiture in voitures)
            {
                if (voiture.EstLouee)
                    return true;
            }
            return false;
        }

        private bool testToutesVoituresLouees()
        {
            List<Voiture> voitures = agence.ListeVoiture();
            foreach (Voiture voiture in voitures)
            {
                if (!voiture.EstLouee)
                    return true;
            }
            return false;
        }

        private void erreur(string classe)
        {
            string message = "";
            if(classe == "")
            {
                message += "Toutes les voitures sont louées. Veuillez revenir plus tard :)";
            }
            else
            {
                message += "L'agence ne contient pas de " + classe;
            }
            MessageBox.Show(message);
        }

        #endregion

        #region Sérialisation / Désérialisation Binaire
        /// <summary>
        /// Méthode de désérialisation binaire
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void importerBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chemin = Explorer("ci");
            try
            {
                //On ouvre un flux binaire
                BinaryFlow bf = new BinaryFlow(chemin);
                agence = bf.importerAgence();
                //On affiche un message indiquant le succès de la désérialisation
                MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Méthode de sérialisation binaire
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exporterBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chemin = Explorer("ci");
            try
            {
                BinaryFlow bf = new BinaryFlow(chemin);
                bf.exporterAgence(agence);
                //S'il n'y a pas eu d'erreurs on affiche un message qui en informe l'utilisateur
                MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("/n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion


        #region Sérialisation / Désérialisation XML

        /// <summary>
        /// Méthode de désérialisation XML
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void importerXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chemin = Explorer("xml");
            if (File.Exists(chemin))
            {
                try
                {
                    XmlFlow xf = new XmlFlow(chemin);
                    agence = xf.importerAgence();
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Méthode de désérialisation XML
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exporterXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chemin = Explorer("xml");
            if (File.Exists(chemin))
            {
                try
                {
                    XmlFlow xf = new XmlFlow(chemin);
                    xf.exporterAgence(agence);
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        #endregion
        private string Explorer(string type)
        {
            string chemin = "";
            OpenFileDialog fileDialogXML = new OpenFileDialog();
            fileDialogXML.Title = "Choisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*."+type+") | *." +type;
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";

                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                chemin = chemin + "\\\\" + nomFichier;
            }
            return chemin;
        }


    }
       

}
