using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wa_exemple
{
    public partial class frmExemple : Form
    {
   
        public frmExemple()
        {
            InitializeComponent();
        }

        private void BtnAssocieImage_Click(object sender, EventArgs e)
        {
            //spécifie que l'image doit s'ajuster dans le picturebox
            picImage34.SizeMode = PictureBoxSizeMode.StretchImage;
            //affiche l'image coucher de soleil dans le picturebox, l'image doit être dans bin/debug
            picImage34.Image = Image.FromFile(Application.StartupPath +  "\\Coucher de soleil.jpg");
        
        }

        private void BtnEnlever_Click_1(object sender, EventArgs e)
        {
            //vérifie qu'il y a une image avant de l'enlever
            if (picImage34.Image != null)
            {
                picImage34.Image = null;
            }
        }

        private void btnExempleSubstring_Click(object sender, EventArgs e)
        {
            string nomPictureBox = picImage34.Name;
            string PremierNombre;
            string DeuxiemeNombre;
            PremierNombre = nomPictureBox.Substring(8, 1);
            DeuxiemeNombre = nomPictureBox.Substring(9, 1);
            MessageBox.Show("nom du pictureBox : " + nomPictureBox);
            MessageBox.Show(" premier nombre : " + PremierNombre);
            MessageBox.Show(" Deuxieme nombre : " + DeuxiemeNombre);
        }

        
    }
}
