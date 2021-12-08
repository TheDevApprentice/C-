namespace wa_exerciceRevision
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauÀ1DimensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauÀ2DimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciceToolStripMenuItem
            // 
            this.exerciceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableauÀ1DimensionToolStripMenuItem,
            this.tableauÀ2DimensionsToolStripMenuItem});
            this.exerciceToolStripMenuItem.Name = "exerciceToolStripMenuItem";
            this.exerciceToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.exerciceToolStripMenuItem.Text = "Exercice";
            // 
            // tableauÀ1DimensionToolStripMenuItem
            // 
            this.tableauÀ1DimensionToolStripMenuItem.Name = "tableauÀ1DimensionToolStripMenuItem";
            this.tableauÀ1DimensionToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.tableauÀ1DimensionToolStripMenuItem.Text = "tableau à 1 dimension";
            this.tableauÀ1DimensionToolStripMenuItem.Click += new System.EventHandler(this.tableauÀ1DimensionToolStripMenuItem_Click);
            // 
            // tableauÀ2DimensionsToolStripMenuItem
            // 
            this.tableauÀ2DimensionsToolStripMenuItem.Name = "tableauÀ2DimensionsToolStripMenuItem";
            this.tableauÀ2DimensionsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.tableauÀ2DimensionsToolStripMenuItem.Text = "tableau à 2 dimensions";
            this.tableauÀ2DimensionsToolStripMenuItem.Click += new System.EventHandler(this.tableauÀ2DimensionsToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauÀ1DimensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauÀ2DimensionsToolStripMenuItem;
    }
}