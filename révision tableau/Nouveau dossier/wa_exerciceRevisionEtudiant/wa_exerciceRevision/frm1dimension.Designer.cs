namespace wa_exerciceRevision
{
    partial class frm1dimension
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInverse = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.btnCumulatif = new System.Windows.Forms.Button();
            this.btnCombien = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCherche = new System.Windows.Forms.Button();
            this.txtCherche = new System.Windows.Forms.TextBox();
            this.lblCherche = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(78, 25);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(129, 57);
            this.btnInverse.TabIndex = 0;
            this.btnInverse.Text = "inverse";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(600, 37);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(234, 436);
            this.lst.TabIndex = 1;
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(866, 37);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(129, 57);
            this.btnAffiche.TabIndex = 2;
            this.btnAffiche.Text = "affiche";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // btnCumulatif
            // 
            this.btnCumulatif.Location = new System.Drawing.Point(78, 106);
            this.btnCumulatif.Name = "btnCumulatif";
            this.btnCumulatif.Size = new System.Drawing.Size(129, 57);
            this.btnCumulatif.TabIndex = 3;
            this.btnCumulatif.Text = "cumulatif";
            this.btnCumulatif.UseVisualStyleBackColor = true;
            this.btnCumulatif.Click += new System.EventHandler(this.btnCumulatif_Click);
            // 
            // btnCombien
            // 
            this.btnCombien.Location = new System.Drawing.Point(32, 41);
            this.btnCombien.Name = "btnCombien";
            this.btnCombien.Size = new System.Drawing.Size(129, 57);
            this.btnCombien.TabIndex = 4;
            this.btnCombien.Text = "combien de nombres";
            this.btnCombien.UseVisualStyleBackColor = true;
            this.btnCombien.Click += new System.EventHandler(this.btnCombien_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(310, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(84, 22);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "5021056";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(179, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "nombre";
            // 
            // btnCherche
            // 
            this.btnCherche.Location = new System.Drawing.Point(31, 34);
            this.btnCherche.Name = "btnCherche";
            this.btnCherche.Size = new System.Drawing.Size(129, 57);
            this.btnCherche.TabIndex = 7;
            this.btnCherche.Text = "cherche";
            this.btnCherche.UseVisualStyleBackColor = true;
            this.btnCherche.Click += new System.EventHandler(this.btnCherche_Click);
            // 
            // txtCherche
            // 
            this.txtCherche.Location = new System.Drawing.Point(310, 51);
            this.txtCherche.Name = "txtCherche";
            this.txtCherche.Size = new System.Drawing.Size(84, 22);
            this.txtCherche.TabIndex = 8;
            // 
            // lblCherche
            // 
            this.lblCherche.AutoSize = true;
            this.lblCherche.Location = new System.Drawing.Point(174, 54);
            this.lblCherche.Name = "lblCherche";
            this.lblCherche.Size = new System.Drawing.Size(130, 17);
            this.lblCherche.TabIndex = 9;
            this.lblCherche.Text = "Nombre à chercher";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCherche);
            this.groupBox1.Controls.Add(this.btnCherche);
            this.groupBox1.Controls.Add(this.txtCherche);
            this.groupBox1.Location = new System.Drawing.Point(48, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCombien);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(48, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 112);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Occurence de chaque nombre";
            // 
            // frm1dimension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCumulatif);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnInverse);
            this.Name = "frm1dimension";
            this.Text = "Exercice de révision sur les tableaux 1 dimension";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnAffiche;
        private System.Windows.Forms.Button btnCumulatif;
        private System.Windows.Forms.Button btnCombien;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCherche;
        private System.Windows.Forms.TextBox txtCherche;
        private System.Windows.Forms.Label lblCherche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

