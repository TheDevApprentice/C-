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
    public partial class frm1dimension : Form
    {
        int[] tableau = { 45, 12, 33, 66, 99, 33, 55, 4, 5, 78, 23, 45, 9, 41 };
        public frm1dimension()
        {
            InitializeComponent();
        }


        private void affiche(int[] tableau)
        {
            for (int indice = 0; indice <= tableau.GetUpperBound(0); indice++)
            {
                lst.Items.Add(tableau[indice]);
            }
        }
        private void btnAffiche_Click(object sender, EventArgs e)
        {
            affiche(tableau);
        }

        private void btnCumulatif_Click(object sender, EventArgs e)
        {
            int[] tableauCumulatif = new int[tableau.GetLength(0)];
            //tableauCumulatif = fabriqueCumulatif(tableau);
            affiche(tableauCumulatif);
        }

        private void btnCombien_Click(object sender, EventArgs e)
        {
            //int[] tableau = combienNombre(txtNombre.Text);
            affiche(tableau);
        }

        private int[] inverse(int[] tableau)
        {
            int temp;

            for (int i = 0; i < tableau.GetLength(0)/2; i++)
            {
                temp = tableau[i];
                tableau[i] = tableau[tableau.GetUpperBound(0) - i]; 
                tableau[tableau.GetUpperBound(0) - i] = temp;
            }
            return tableau; 
        }
        private void btnInverse_Click(object sender, EventArgs e)
        {
            inverse(tableau);
            affiche(tableau);
        }
        private void recherche(int[] tableau, int ImputUser)
        {
            int i;
            int valeur = 0; 
            for ( i = 0; i < tableau.Length; i++)
            {
                if(tableau[i] == ImputUser)
                {
                    valeur = i; 
                }
            }
            txtCherche.Text = valeur.ToString();
        }
        private void btnCherche_Click(object sender, EventArgs e)
        {
            int ImputUser = int.Parse(txtCherche.Text);

            recherche(tableau, ImputUser);

        }
    }
}
