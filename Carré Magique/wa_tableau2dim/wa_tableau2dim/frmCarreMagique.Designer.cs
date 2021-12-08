namespace wa_tableau2dim
{
    partial class frmCarreMagique
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
            this.txt00 = new System.Windows.Forms.TextBox();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.btnCarree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt00
            // 
            this.txt00.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt00.Location = new System.Drawing.Point(134, 61);
            this.txt00.Name = "txt00";
            this.txt00.Size = new System.Drawing.Size(63, 34);
            this.txt00.TabIndex = 0;
            this.txt00.Text = "8";
            // 
            // txt01
            // 
            this.txt01.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt01.Location = new System.Drawing.Point(220, 61);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(63, 34);
            this.txt01.TabIndex = 1;
            this.txt01.Text = "3";
            // 
            // txt02
            // 
            this.txt02.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt02.Location = new System.Drawing.Point(300, 61);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(63, 34);
            this.txt02.TabIndex = 2;
            this.txt02.Text = "4";
            // 
            // txt10
            // 
            this.txt10.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt10.Location = new System.Drawing.Point(134, 116);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(63, 34);
            this.txt10.TabIndex = 3;
            this.txt10.Text = "1";
            // 
            // txt11
            // 
            this.txt11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt11.Location = new System.Drawing.Point(220, 116);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(63, 34);
            this.txt11.TabIndex = 4;
            this.txt11.Text = "5";
            // 
            // txt12
            // 
            this.txt12.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt12.Location = new System.Drawing.Point(300, 116);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(63, 34);
            this.txt12.TabIndex = 5;
            this.txt12.Text = "9";
            // 
            // txt22
            // 
            this.txt22.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt22.Location = new System.Drawing.Point(300, 171);
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(63, 34);
            this.txt22.TabIndex = 8;
            this.txt22.Text = "2";
            // 
            // txt21
            // 
            this.txt21.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt21.Location = new System.Drawing.Point(220, 171);
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(63, 34);
            this.txt21.TabIndex = 7;
            this.txt21.Text = "7";
            // 
            // txt20
            // 
            this.txt20.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt20.Location = new System.Drawing.Point(134, 171);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(63, 34);
            this.txt20.TabIndex = 6;
            this.txt20.Text = "6";
            // 
            // btnCarree
            // 
            this.btnCarree.Location = new System.Drawing.Point(181, 237);
            this.btnCarree.Name = "btnCarree";
            this.btnCarree.Size = new System.Drawing.Size(135, 56);
            this.btnCarree.TabIndex = 9;
            this.btnCarree.Text = "Carrée magique ?";
            this.btnCarree.UseVisualStyleBackColor = true;
            this.btnCarree.Click += new System.EventHandler(this.btnCarree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 369);
            this.Controls.Add(this.btnCarree);
            this.Controls.Add(this.txt22);
            this.Controls.Add(this.txt21);
            this.Controls.Add(this.txt20);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.txt00);
            this.Name = "Form1";
            this.Text = "Carrée magique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt00;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.Button btnCarree;
    }
}

