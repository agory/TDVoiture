namespace App
{
    partial class FSuppVoiture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_voiture = new System.Windows.Forms.ComboBox();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_supp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPPRIMER UNE VOITURE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture :";
            // 
            // cb_voiture
            // 
            this.cb_voiture.FormattingEnabled = true;
            this.cb_voiture.Location = new System.Drawing.Point(183, 65);
            this.cb_voiture.Name = "cb_voiture";
            this.cb_voiture.Size = new System.Drawing.Size(147, 21);
            this.cb_voiture.TabIndex = 2;
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(118, 125);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 3;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_supp
            // 
            this.bt_supp.Location = new System.Drawing.Point(230, 125);
            this.bt_supp.Name = "bt_supp";
            this.bt_supp.Size = new System.Drawing.Size(75, 23);
            this.bt_supp.TabIndex = 4;
            this.bt_supp.Text = "Supprimer";
            this.bt_supp.UseVisualStyleBackColor = true;
            this.bt_supp.Click += new System.EventHandler(this.bt_supp_Click);
            // 
            // FSuppVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 166);
            this.Controls.Add(this.bt_supp);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.cb_voiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSuppVoiture";
            this.Text = "Supprimer une voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_voiture;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_supp;
    }
}