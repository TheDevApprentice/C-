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
    public partial class frm2dimensions : Form
    {
        Single[,] tableau = { { 77, 88, 99 }, { 85, 75, 49 }, { 94, 92, 88 }, { 75, 84, 85 } };
        public frm2dimensions()
        {
            InitializeComponent();
        }
     
        private void btnMoyenneEtudiant_Click(object sender, EventArgs e)
        {
            Single reponse = 0;
            //reponse = moyenneEtudiant(tableau, int.Parse(txtNoEtudiant.Text));
            MessageBox.Show("La moyenne est : " + reponse);
        }
        
      
    
        private void btnNombreEtudiantEnHaut80_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nombre etudiant en haut de 80 : " + nombreEtudiantEnHaut80(tableau)); 
        }
        private void affiche(int[,] tableau)
        {
      
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {   string chaine = "";
                for (int colonne = 0; colonne <= tableau.GetUpperBound(1); colonne++)
                {
                    chaine =  chaine + tableau[ligne, colonne].ToString().PadRight(6,' ')  ;
                }
                lst.Items.Add(chaine);
            }
        }
  
        private void btnDiagonaleAZero_Click(object sender, EventArgs e)
        {
            int[,] tableau = { {2,-4,3,5 }, { 6,5,3,1}, {8,7,3,5 }, { 2,3,7,-3} };
            affiche(tableau);
          //  metDiagonaleAZero(tableau);
            affiche(tableau);
        }
      
        private void btnPlusGrandNombre_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("Le plus grand est : " + PlusGrandNombre(tableau));
        }
    }
}
