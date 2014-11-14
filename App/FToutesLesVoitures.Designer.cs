namespace App
{
    partial class FToutesLesVoitures
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_personne = new System.Windows.Forms.ComboBox();
            this.cbx_trie = new System.Windows.Forms.ComboBox();
            this.dgv_agence = new System.Windows.Forms.DataGridView();
            this.bt_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AFFICHAGE DES VOITURES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la personne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trier sur :";
            // 
            // cbx_personne
            // 
            this.cbx_personne.FormattingEnabled = true;
            this.cbx_personne.Location = new System.Drawing.Point(185, 50);
            this.cbx_personne.Name = "cbx_personne";
            this.cbx_personne.Size = new System.Drawing.Size(121, 21);
            this.cbx_personne.TabIndex = 3;
            // 
            // cbx_trie
            // 
            this.cbx_trie.FormattingEnabled = true;
            this.cbx_trie.Location = new System.Drawing.Point(574, 50);
            this.cbx_trie.Name = "cbx_trie";
            this.cbx_trie.Size = new System.Drawing.Size(121, 21);
            this.cbx_trie.TabIndex = 4;
            // 
            // dgv_agence
            // 
            this.dgv_agence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agence.Location = new System.Drawing.Point(12, 95);
            this.dgv_agence.Name = "dgv_agence";
            this.dgv_agence.Size = new System.Drawing.Size(805, 150);
            this.dgv_agence.TabIndex = 5;
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(381, 256);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 6;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            // 
            // FToutesLesVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 291);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.dgv_agence);
            this.Controls.Add(this.cbx_trie);
            this.Controls.Add(this.cbx_personne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FToutesLesVoitures";
            this.Text = "Affichage des voitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_personne;
        private System.Windows.Forms.ComboBox cbx_trie;
        private System.Windows.Forms.DataGridView dgv_agence;
        private System.Windows.Forms.Button bt_fermer;
    }
}