using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wa_exerciceRevision
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tableauÀ1DimensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForme = new frm1dimension();
            maForme.ShowDialog();
        }

        private void tableauÀ2DimensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForme = new frm2dimensions();
            maForme.ShowDialog();
        }
    }
}
