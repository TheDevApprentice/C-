namespace wa_exemple
{
    partial class frmExemple
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
            this.btnAssocieImage = new System.Windows.Forms.Button();
            this.btnEnlever = new System.Windows.Forms.Button();
            this.picImage34 = new System.Windows.Forms.PictureBox();
            this.btnExempleSubstring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage34)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssocieImage
            // 
            this.btnAssocieImage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocieImage.Location = new System.Drawing.Point(88, 231);
            this.btnAssocieImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssocieImage.Name = "btnAssocieImage";
            this.btnAssocieImage.Size = new System.Drawing.Size(233, 48);
            this.btnAssocieImage.TabIndex = 0;
            this.btnAssocieImage.Text = "associé une image";
            this.btnAssocieImage.UseVisualStyleBackColor = true;
            this.btnAssocieImage.Click += new System.EventHandler(this.BtnAssocieImage_Click);
            // 
            // btnEnlever
            // 
            this.btnEnlever.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnlever.Location = new System.Drawing.Point(88, 301);
            this.btnEnlever.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnlever.Name = "btnEnlever";
            this.btnEnlever.Size = new System.Drawing.Size(233, 39);
            this.btnEnlever.TabIndex = 3;
            this.btnEnlever.Text = "enlever une image";
            this.btnEnlever.UseVisualStyleBackColor = true;
            this.btnEnlever.Click += new System.EventHandler(this.BtnEnlever_Click_1);
            // 
            // picImage34
            // 
            this.picImage34.Location = new System.Drawing.Point(88, 28);
            this.picImage34.Margin = new System.Windows.Forms.Padding(4);
            this.picImage34.Name = "picImage34";
            this.picImage34.Size = new System.Drawing.Size(233, 167);
            this.picImage34.TabIndex = 4;
            this.picImage34.TabStop = false;
            // 
            // btnExempleSubstring
            // 
            this.btnExempleSubstring.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExempleSubstring.Location = new System.Drawing.Point(390, 28);
            this.btnExempleSubstring.Margin = new System.Windows.Forms.Padding(4);
            this.btnExempleSubstring.Name = "btnExempleSubstring";
            this.btnExempleSubstring.Size = new System.Drawing.Size(233, 70);
            this.btnExempleSubstring.TabIndex = 5;
            this.btnExempleSubstring.Text = "extraire des caractères";
            this.btnExempleSubstring.UseVisualStyleBackColor = true;
            this.btnExempleSubstring.Click += new System.EventHandler(this.btnExempleSubstring_Click);
            // 
            // frmExemple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 382);
            this.Controls.Add(this.btnExempleSubstring);
            this.Controls.Add(this.picImage34);
            this.Controls.Add(this.btnEnlever);
            this.Controls.Add(this.btnAssocieImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExemple";
            this.Text = "Exemple pour afficher une image";
            ((System.ComponentModel.ISupportInitialize)(this.picImage34)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssocieImage;
        private System.Windows.Forms.Button btnEnlever;
        private System.Windows.Forms.PictureBox picImage34;
        private System.Windows.Forms.Button btnExempleSubstring;
    }
}

