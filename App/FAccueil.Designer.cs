namespace App
{
    partial class FAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerBinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterBinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoiture = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneVoiture = new System.Windows.Forms.ToolStripMenuItem();
            this.personnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnePersonne = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnePersonne = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.louerUneVoiture = new System.Windows.Forms.ToolStripMenuItem();
            this.rendreUneVoiture = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesVoitures = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesPersonnes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerXMLToolStripMenuItem,
            this.exporterXMLToolStripMenuItem,
            this.importerBinaireToolStripMenuItem,
            this.exporterBinaireToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // importerXMLToolStripMenuItem
            // 
            this.importerXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importerXMLToolStripMenuItem.Image")));
            this.importerXMLToolStripMenuItem.Name = "importerXMLToolStripMenuItem";
            this.importerXMLToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.importerXMLToolStripMenuItem.Text = "ImporterXML";
            this.importerXMLToolStripMenuItem.Click += new System.EventHandler(this.importerXMLToolStripMenuItem_Click);
            // 
            // exporterXMLToolStripMenuItem
            // 
            this.exporterXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exporterXMLToolStripMenuItem.Image")));
            this.exporterXMLToolStripMenuItem.Name = "exporterXMLToolStripMenuItem";
            this.exporterXMLToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exporterXMLToolStripMenuItem.Text = "ExporterXML";
            this.exporterXMLToolStripMenuItem.Click += new System.EventHandler(this.exporterXMLToolStripMenuItem_Click);
            // 
            // importerBinaireToolStripMenuItem
            // 
            this.importerBinaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importerBinaireToolStripMenuItem.Image")));
            this.importerBinaireToolStripMenuItem.Name = "importerBinaireToolStripMenuItem";
            this.importerBinaireToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.importerBinaireToolStripMenuItem.Text = "ImporterBinaire";
            this.importerBinaireToolStripMenuItem.Click += new System.EventHandler(this.importerBinaireToolStripMenuItem_Click);
            // 
            // exporterBinaireToolStripMenuItem
            // 
            this.exporterBinaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exporterBinaireToolStripMenuItem.Image")));
            this.exporterBinaireToolStripMenuItem.Name = "exporterBinaireToolStripMenuItem";
            this.exporterBinaireToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exporterBinaireToolStripMenuItem.Text = "ExporterBinaire";
            this.exporterBinaireToolStripMenuItem.Click += new System.EventHandler(this.exporterBinaireToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voituresToolStripMenuItem,
            this.personnesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // voituresToolStripMenuItem
            // 
            this.voituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneVoiture,
            this.supprimerUneVoiture});
            this.voituresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("voituresToolStripMenuItem.Image")));
            this.voituresToolStripMenuItem.Name = "voituresToolStripMenuItem";
            this.voituresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.voituresToolStripMenuItem.Text = "Voitures";
            // 
            // ajouterUneVoiture
            // 
            this.ajouterUneVoiture.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUneVoiture.Image")));
            this.ajouterUneVoiture.Name = "ajouterUneVoiture";
            this.ajouterUneVoiture.Size = new System.Drawing.Size(192, 22);
            this.ajouterUneVoiture.Text = "Ajouter une voiture";
            this.ajouterUneVoiture.Click += new System.EventHandler(this.ajouterUneVoiture_Click);
            // 
            // supprimerUneVoiture
            // 
            this.supprimerUneVoiture.Image = ((System.Drawing.Image)(resources.GetObject("supprimerUneVoiture.Image")));
            this.supprimerUneVoiture.Name = "supprimerUneVoiture";
            this.supprimerUneVoiture.Size = new System.Drawing.Size(192, 22);
            this.supprimerUneVoiture.Text = "Supprimer une voiture";
            this.supprimerUneVoiture.Click += new System.EventHandler(this.supprimerUneVoiture_Click);
            // 
            // personnesToolStripMenuItem
            // 
            this.personnesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnePersonne,
            this.supprimerUnePersonne});
            this.personnesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personnesToolStripMenuItem.Image")));
            this.personnesToolStripMenuItem.Name = "personnesToolStripMenuItem";
            this.personnesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personnesToolStripMenuItem.Text = "Personnes";
            // 
            // ajouterUnePersonne
            // 
            this.ajouterUnePersonne.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnePersonne.Image")));
            this.ajouterUnePersonne.Name = "ajouterUnePersonne";
            this.ajouterUnePersonne.Size = new System.Drawing.Size(204, 22);
            this.ajouterUnePersonne.Text = "Ajouter une personne";
            this.ajouterUnePersonne.Click += new System.EventHandler(this.ajouterUnePersonne_Click);
            // 
            // supprimerUnePersonne
            // 
            this.supprimerUnePersonne.Image = ((System.Drawing.Image)(resources.GetObject("supprimerUnePersonne.Image")));
            this.supprimerUnePersonne.Name = "supprimerUnePersonne";
            this.supprimerUnePersonne.Size = new System.Drawing.Size(204, 22);
            this.supprimerUnePersonne.Text = "Supprimer une personne";
            this.supprimerUnePersonne.Click += new System.EventHandler(this.supprimerUnePersonne_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.louerUneVoiture,
            this.rendreUneVoiture});
            this.locationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationsToolStripMenuItem.Image")));
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // louerUneVoiture
            // 
            this.louerUneVoiture.Image = ((System.Drawing.Image)(resources.GetObject("louerUneVoiture.Image")));
            this.louerUneVoiture.Name = "louerUneVoiture";
            this.louerUneVoiture.Size = new System.Drawing.Size(174, 22);
            this.louerUneVoiture.Text = "Louer une voiture";
            this.louerUneVoiture.Click += new System.EventHandler(this.louerUneVoiture_Click);
            // 
            // rendreUneVoiture
            // 
            this.rendreUneVoiture.Image = ((System.Drawing.Image)(resources.GetObject("rendreUneVoiture.Image")));
            this.rendreUneVoiture.Name = "rendreUneVoiture";
            this.rendreUneVoiture.Size = new System.Drawing.Size(174, 22);
            this.rendreUneVoiture.Text = "Rendre une voiture";
            this.rendreUneVoiture.Click += new System.EventHandler(this.rendreUneVoiture_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutesLesVoitures,
            this.toutesLesPersonnes});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // toutesLesVoitures
            // 
            this.toutesLesVoitures.Image = ((System.Drawing.Image)(resources.GetObject("toutesLesVoitures.Image")));
            this.toutesLesVoitures.Name = "toutesLesVoitures";
            this.toutesLesVoitures.Size = new System.Drawing.Size(184, 22);
            this.toutesLesVoitures.Text = "Toutes les voitures";
            this.toutesLesVoitures.Click += new System.EventHandler(this.toutesLesVoitures_Click);
            // 
            // toutesLesPersonnes
            // 
            this.toutesLesPersonnes.Image = ((System.Drawing.Image)(resources.GetObject("toutesLesPersonnes.Image")));
            this.toutesLesPersonnes.Name = "toutesLesPersonnes";
            this.toutesLesPersonnes.Size = new System.Drawing.Size(184, 22);
            this.toutesLesPersonnes.Text = "Toutes les personnes";
            this.toutesLesPersonnes.Click += new System.EventHandler(this.toutesLesPersonnes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(221, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGENCE A3P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BIENVENUE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Agence A3P\r\n66 avenue Forza\r\n69009 LYON";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 52);
            this.label5.TabIndex = 2;
            this.label5.Text = "Téléphone :\r\n04 74 99 99 99\r\nMail :\r\na3p@automobile.fr";
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoiture;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoiture;
        private System.Windows.Forms.ToolStripMenuItem personnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnePersonne;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnePersonne;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem louerUneVoiture;
        private System.Windows.Forms.ToolStripMenuItem rendreUneVoiture;
        private System.Windows.Forms.ToolStripMenuItem toutesLesVoitures;
        private System.Windows.Forms.ToolStripMenuItem toutesLesPersonnes;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerBinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterBinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterXMLToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}
