using Metier;
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
            //On affiche une fenêtre permettant de choisir un fichier à charger
            OpenFileDialog FileDialogBin = new OpenFileDialog();
            FileDialogBin.Title = "Choisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            //Si l'utilisateur clique sur "Charger"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier à charger
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream unFlux = null;
                BinaryFormatter fs;
                try
                {
                    //On ouvre un flux binaire
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Open);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    //On vide la collection avant de récupérer le contenu désérialiser
                    agence = (Agence)fs.Deserialize(unFlux);
                    //On affiche un message indiquant le succès de la désérialisation
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    unFlux.Close();
                }
            }
        }

        /// <summary>
        /// Méthode de sérialisation binaire
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exporterBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On affiche une fenêtre permettant de saisir un fichier dans lequel sauvegarder
            SaveFileDialog FileDialogBin = new SaveFileDialog();
            FileDialogBin.Title = "Saisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            //Si l'utilisateur clique sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet choisi dans lequel on remplace \ par \\
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                //On crée un flux binaire de sortie
                FileStream unFlux = null;
                BinaryFormatter fs;
                String nom_fichier = nomFichier;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Create);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    fs.Serialize(unFlux, agence);
                    //S'il n'y a pas eu d'erreurs on affiche un message qui en informe l'utilisateur
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("/n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    unFlux.Close();
                }
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
            OpenFileDialog fileDialogXML = new OpenFileDialog();
            fileDialogXML.Title = "Choisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream stream = null;
                XmlSerializer serializer;
                Directory.SetCurrentDirectory(chemin);
                if (File.Exists(nomFichier))
                {
                    try
                    {
                        stream = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
                        serializer = new XmlSerializer(typeof(Agence));
                        agence = (Agence)serializer.Deserialize(stream);
                        stream.Close();
                        MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        stream.Close();
                    }
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
            SaveFileDialog fileDialogXML = new SaveFileDialog();
            fileDialogXML.Title = "Saisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream stream = null;
                XmlSerializer serializer;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    stream = new FileStream(nomFichier, FileMode.Create);
                    serializer = new XmlSerializer(typeof(Agence));
                    serializer.Serialize(stream, agence);
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
        }
        #endregion

    }
       

}
