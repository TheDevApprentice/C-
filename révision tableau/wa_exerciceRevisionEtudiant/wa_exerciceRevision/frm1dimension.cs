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
            int[] tableauCumulatif = new int[1000];
            tableauCumulatif = fabriqueCumulatif(tableau);
            affiche(tableauCumulatif);
        }
        private int[] fabriqueCumulatif(int[] tableau)
        {
            int temp;
           
            int cumulatifs = 0;
            int[] cumulatif = new int[tableau.GetUpperBound(0)];


            for (int i = 0; i < tableau.GetUpperBound(0); i++)
            {
                temp = tableau[i];

                if (i > 0)
                {
                    cumulatifs = cumulatif[i - 1];
                }

                cumulatif[i] = temp + cumulatifs;
            }

            return cumulatif;
        }
  

        private void btnInverse_Click(object sender, EventArgs e)
        {
            inverse(tableau);
        }
        private void inverse(int[] tableau)
        {
            int temp;
            int[] temps = tableau;

            for (int i = 0; i < temps.GetLength(0) / 2; i++)
            {
                temp = temps[i];
                temps[i] = temps[temps.GetUpperBound(0) - i];
                temps[temps.GetUpperBound(0) - i] = temp;
            }

            affiche(temps);
        }

        private void btnCherche_Click(object sender, EventArgs e)
        {
            int imputUser = int.Parse(txtCherche.Text);

            recherche(tableau, imputUser);

        }
        private void recherche(int[] tableau, int ImputUser)
        {
            int temp = -1;
            int i = 0;
            bool trouver = false; 

            while (i <= tableau.Length && trouver == false)
            {
                if (tableau[i] == ImputUser)
                {
                     temp = i;
                    trouver = true;
                  
                }
                i++;
            }
          
            txtCherche.Text = temp.ToString();
        }
    }
                
   }

