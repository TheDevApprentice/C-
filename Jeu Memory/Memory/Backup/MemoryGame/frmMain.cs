using System;
using System.Drawing;
using System.Windows.Forms;
using MemoryLib;

namespace MemoryGame
{
    public partial class frmMain : Form
    {
        private Difficulty _difficulty = Difficulty.Expert;

        public frmMain()
        {
            this.InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.cmbLevel.SelectedIndex = 2;
        }

        private void memory_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.memory.Width + 75, this.memory.Height + 200);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this._difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), this.cmbLevel.SelectedItem.ToString());
            this.lblLevel.Text = string.Format("Level: {0}", this._difficulty);
            try
            {
                //this.memory.ImageDirectory = @"Pieces\";
                this.memory.CSMembersId = this.GetIds();
                this.memory.Start(this._difficulty);
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Error while loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[] GetIds()
        {
            int[] ids = new int[]
            {
                1,          // Nix
                39449,      // BruNews
                13557,      // Darksidious
                100635,     // econs
                58031,      // malalam
                19734,      // vecchio56
                19303,      // jesusonline
                401740,     // PCPT
                2359,       // Renfield
                10023,      // coq
                3267,       // Delphiprog
                2204,       // jack
                941,        // Willi
                53675,      // Sebmafate
                5912,       // MorpionMx
                13319,      // Bidou
                148258,     // neodante
                375045,     // Nurgle
                43739,      // Twinuts
                15669       // EBArtSoft
            };
            return ids;
        }

        private void memory_UserWin(double seconds)
        {
            this.lblWinner.Text = string.Format("Gagner en {0}sec", seconds);
            MessageBox.Show(string.Format("Bravo!\nVous avez gagner en {0}sec", seconds), "Gagner!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}