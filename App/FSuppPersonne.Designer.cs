namespace App
{
    partial class FSuppPersonne
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
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_personne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(125, 145);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 0;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(246, 145);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 1;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUPPRIMER UNE PERSONNE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personne :";
            // 
            // cb_personne
            // 
            this.cb_personne.FormattingEnabled = true;
            this.cb_personne.Location = new System.Drawing.Point(173, 76);
            this.cb_personne.Name = "cb_personne";
            this.cb_personne.Size = new System.Drawing.Size(160, 21);
            this.cb_personne.TabIndex = 4;
            // 
            // FSuppPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 193);
            this.Controls.Add(this.cb_personne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_fermer);
            this.Name = "FSuppPersonne";
            this.Text = "Supprimer une personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_personne;
    }
}