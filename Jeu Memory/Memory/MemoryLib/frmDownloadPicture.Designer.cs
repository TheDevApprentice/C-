namespace MemoryLib
{
    partial class frmDownloadPicture
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
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrentPicture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgrBar
            // 
            this.pgrBar.Location = new System.Drawing.Point(12, 62);
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(268, 23);
            this.pgrBar.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(205, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPicture
            // 
            this.lblCurrentPicture.AutoSize = true;
            this.lblCurrentPicture.Location = new System.Drawing.Point(12, 46);
            this.lblCurrentPicture.Name = "lblCurrentPicture";
            this.lblCurrentPicture.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentPicture.TabIndex = 2;
            this.lblCurrentPicture.Text = "Downloading...";
            // 
            // frmDownloadPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 146);
            this.ControlBox = false;
            this.Controls.Add(this.lblCurrentPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pgrBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDownloadPicture";
            this.ShowInTaskbar = false;
            this.Text = "Downloading...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgrBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrentPicture;
    }
}