namespace App
{
    partial class FRestitution
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
            this.cb_rendreVoiture = new System.Windows.Forms.ComboBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_valid = new System.Windows.Forms.Button();
            this.lbl_id_loueur = new System.Windows.Forms.Label();
            this.lbl_loueur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENDRE UNE VOITURE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture à rendre :";
            // 
            // cb_rendreVoiture
            // 
            this.cb_rendreVoiture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rendreVoiture.FormattingEnabled = true;
            this.cb_rendreVoiture.Location = new System.Drawing.Point(203, 120);
            this.cb_rendreVoiture.Name = "cb_rendreVoiture";
            this.cb_rendreVoiture.Size = new System.Drawing.Size(185, 21);
            this.cb_rendreVoiture.TabIndex = 2;
            this.cb_rendreVoiture.SelectedIndexChanged += new System.EventHandler(this.cb_rendreVoiture_SelectedIndexChanged);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(129, 176);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_valid
            // 
            this.bt_valid.Location = new System.Drawing.Point(249, 176);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(75, 23);
            this.bt_valid.TabIndex = 4;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
            // 
            // lbl_id_loueur
            // 
            this.lbl_id_loueur.AutoSize = true;
            this.lbl_id_loueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_loueur.Location = new System.Drawing.Point(204, 144);
            this.lbl_id_loueur.Name = "lbl_id_loueur";
            this.lbl_id_loueur.Size = new System.Drawing.Size(0, 16);
            this.lbl_id_loueur.TabIndex = 5;
            // 
            // lbl_loueur
            // 
            this.lbl_loueur.AutoSize = true;
            this.lbl_loueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loueur.Location = new System.Drawing.Point(61, 144);
            this.lbl_loueur.Name = "lbl_loueur";
            this.lbl_loueur.Size = new System.Drawing.Size(120, 16);
            this.lbl_loueur.TabIndex = 6;
            this.lbl_loueur.Text = "Nom du loueur : ";
            // 
            // FRestitution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 267);
            this.Controls.Add(this.lbl_loueur);
            this.Controls.Add(this.lbl_id_loueur);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.cb_rendreVoiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRestitution";
            this.Text = "Rendre une voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_rendreVoiture;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Label lbl_id_loueur;
        private System.Windows.Forms.Label lbl_loueur;
    }
}