namespace MemoryLib
{
    partial class Memory
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
            if (this._memoryGame != null)
            {
                this._memoryGame.Dispose();
                this._memoryGame = null;
            }
            if (this._fontBrush != null)
            {
                this._fontBrush.Dispose();
                this._fontBrush = null;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Memory";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Memory_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
