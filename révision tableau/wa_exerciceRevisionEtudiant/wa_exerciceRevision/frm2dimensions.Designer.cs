namespace wa_exerciceRevision
{
    partial class frm2dimensions
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
            this.lst = new System.Windows.Forms.ListBox();
            this.btnMoyenneEtudiant = new System.Windows.Forms.Button();
            this.txtNoEtudiant = new System.Windows.Forms.TextBox();
            this.btnNombreEtudiantEnHaut80 = new System.Windows.Forms.Button();
            this.btnDiagonaleAZero = new System.Windows.Forms.Button();
            this.btnPlusGrandNombre = new System.Windows.Forms.Button();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(385, 34);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(235, 404);
            this.lst.TabIndex = 4;
            // 
            // btnMoyenneEtudiant
            // 
            this.btnMoyenneEtudiant.Location = new System.Drawing.Point(50, 41);
            this.btnMoyenneEtudiant.Name = "btnMoyenneEtudiant";
            this.btnMoyenneEtudiant.Size = new System.Drawing.Size(129, 57);
            this.btnMoyenneEtudiant.TabIndex = 5;
            this.btnMoyenneEtudiant.Text = "Moyenne d\'un étudiant";
            this.btnMoyenneEtudiant.UseVisualStyleBackColor = true;
            this.btnMoyenneEtudiant.Click += new System.EventHandler(this.btnMoyenneEtudiant_Click);
            // 
            // txtNoEtudiant
            // 
            this.txtNoEtudiant.Location = new System.Drawing.Point(281, 58);
            this.txtNoEtudiant.Name = "txtNoEtudiant";
            this.txtNoEtudiant.Size = new System.Drawing.Size(50, 22);
            this.txtNoEtudiant.TabIndex = 6;
            this.txtNoEtudiant.Text = "2";
            // 
            // btnNombreEtudiantEnHaut80
            // 
            this.btnNombreEtudiantEnHaut80.Location = new System.Drawing.Point(50, 121);
            this.btnNombreEtudiantEnHaut80.Name = "btnNombreEtudiantEnHaut80";
            this.btnNombreEtudiantEnHaut80.Size = new System.Drawing.Size(129, 57);
            this.btnNombreEtudiantEnHaut80.TabIndex = 7;
            this.btnNombreEtudiantEnHaut80.Text = "Nombre etudiant en haut de 80";
            this.btnNombreEtudiantEnHaut80.UseVisualStyleBackColor = true;
            this.btnNombreEtudiantEnHaut80.Click += new System.EventHandler(this.btnNombreEtudiantEnHaut80_Click);
            // 
            // btnDiagonaleAZero
            // 
            this.btnDiagonaleAZero.Location = new System.Drawing.Point(50, 298);
            this.btnDiagonaleAZero.Name = "btnDiagonaleAZero";
            this.btnDiagonaleAZero.Size = new System.Drawing.Size(129, 57);
            this.btnDiagonaleAZero.TabIndex = 8;
            this.btnDiagonaleAZero.Text = "diagonale à zéro";
            this.btnDiagonaleAZero.UseVisualStyleBackColor = true;
            this.btnDiagonaleAZero.Click += new System.EventHandler(this.btnDiagonaleAZero_Click);
            // 
            // btnPlusGrandNombre
            // 
            this.btnPlusGrandNombre.Location = new System.Drawing.Point(50, 206);
            this.btnPlusGrandNombre.Name = "btnPlusGrandNombre";
            this.btnPlusGrandNombre.Size = new System.Drawing.Size(129, 57);
            this.btnPlusGrandNombre.TabIndex = 9;
            this.btnPlusGrandNombre.Text = "Plus grand nombre";
            this.btnPlusGrandNombre.UseVisualStyleBackColor = true;
            this.btnPlusGrandNombre.Click += new System.EventHandler(this.btnPlusGrandNombre_Click);
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Location = new System.Drawing.Point(197, 61);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(78, 17);
            this.lblEtudiant.TabIndex = 10;
            this.lblEtudiant.Text = "NoEtudiant";
            // 
            // frm2dimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 454);
            this.Controls.Add(this.lblEtudiant);
            this.Controls.Add(this.btnPlusGrandNombre);
            this.Controls.Add(this.btnDiagonaleAZero);
            this.Controls.Add(this.btnNombreEtudiantEnHaut80);
            this.Controls.Add(this.txtNoEtudiant);
            this.Controls.Add(this.btnMoyenneEtudiant);
            this.Controls.Add(this.lst);
            this.Name = "frm2dimensions";
            this.Text = "Exercice de révision sur les tableaux à 2 dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnMoyenneEtudiant;
        private System.Windows.Forms.TextBox txtNoEtudiant;
        private System.Windows.Forms.Button btnNombreEtudiantEnHaut80;
        private System.Windows.Forms.Button btnDiagonaleAZero;
        private System.Windows.Forms.Button btnPlusGrandNombre;
        private System.Windows.Forms.Label lblEtudiant;
    }
}