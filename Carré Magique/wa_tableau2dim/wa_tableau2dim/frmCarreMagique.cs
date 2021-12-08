using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wa_tableau2dim
{
    public partial class frmCarreMagique : Form
    {
        CarreeMagique carreMagique = new CarreeMagique();
        public frmCarreMagique()
        {
            InitializeComponent();
        }
       
        private TextBox[,] assignationTextBox()
        {
            TextBox[,] tableauTextBox = new TextBox[3,3];
            tableauTextBox[0, 0] = txt00;
            tableauTextBox[0, 1] = txt01;
            tableauTextBox[0, 2] = txt02;
            tableauTextBox[1, 0] = txt10;
            tableauTextBox[1, 1] = txt11;
            tableauTextBox[1, 2] = txt12;
            tableauTextBox[2, 0] = txt20;
            tableauTextBox[2, 1] = txt21;
            tableauTextBox[2, 2] = txt22;
            return tableauTextBox;
        }
        private int[,] remplitTableau(TextBox[,] tableauTextBox)
        {
            int[,] tableau = new int[3, 3];
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                try
                {
                    for (int colonne = 0; colonne <= tableau.GetUpperBound(1); colonne++)
                    {
                        tableau[ligne, colonne] = int.Parse(tableauTextBox[ligne, colonne].Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Il faut rentrer un chiffre !");
                }
                
            }
            return tableau;
        }

        private void btnCarree_Click(object sender, EventArgs e)
        {
            int[,] tableau = new int[3, 3];
            TextBox[,] tableauTextBox = new TextBox[3, 3];
            Boolean reponse = false;
            int sommeLigne = 0;
            int sommeColonne = 0;
            int sommeDiagonale = 0;
            tableauTextBox = assignationTextBox();
            tableau = remplitTableau(tableauTextBox);

            if (carreMagique.TousNombresPresents1Fois(tableau) == true)
            {
                if (carreMagique.verifieLigne(tableau, ref sommeLigne) == true)
                {
                    if (carreMagique.verifieColonne(tableau, ref sommeColonne) == true && sommeLigne == sommeColonne)
                    {
                        if (carreMagique.verifieDiagonale(tableau, ref sommeDiagonale) == true && sommeLigne == sommeDiagonale)
                        {
                            reponse = true;
                        }
                        else
                            MessageBox.Show("problème de compte sur les diagonales");

                    }
                    else
                        MessageBox.Show("problème de compte sur les colonnes");
                }
                else
                    MessageBox.Show("problème de compte sur les lignes");
            }
            else
                MessageBox.Show("problème de nombres non uniques");
            if (reponse == true)
            {
                MessageBox.Show("C'est un carrée magique");
            }
            else
            {
                MessageBox.Show("C'est n'est pas un carrée magique");
            }


        }
    }
}
