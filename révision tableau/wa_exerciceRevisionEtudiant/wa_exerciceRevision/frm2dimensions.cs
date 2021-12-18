using System;
using System.Windows.Forms;

namespace wa_exerciceRevision
{
    public partial class frm2dimensions : Form
    {
        int[,] tableau = { { 77, 88, 99 }, { 85, 75, 49 }, { 94, 92, 88 }, { 75, 84, 85 } };
        public frm2dimensions()
        {
            InitializeComponent();
        }

        private void btnMoyenneEtudiant_Click(object sender, EventArgs e)
        {
            int reponse = 0;
            reponse = moyenneEtudiant(tableau, int.Parse(txtNoEtudiant.Text));
            MessageBox.Show("La moyenne est : " + reponse);
        }

        private int moyenneEtudiant(int[,] tableau, int nbetudiant)
        {
            int somme = 0;
            int temp = 0;

            int moyenne = 0;

            int i = nbetudiant - 1;

            for (int j = 0; j < tableau.GetLength(1); j++)
            {

                temp = tableau[i, j];
                somme = temp + somme;
            }

            moyenne = somme / 3;



            return moyenne;
        }


        private void btnNombreEtudiantEnHaut80_Click(object sender, EventArgs e)
        {
            double reponse = 0;
            reponse = nombreEtudiantEnHaut80(tableau, int.Parse(txtNoEtudiant.Text));
            MessageBox.Show("Nombre etudiant en haut de 80 : " + reponse);
        }
        private int nombreEtudiantEnHaut80(int[,] tableau, int nbetudiant)
        {
            int a = 0;
            int somme = 0;
            int temp = 0;

            int moyenne = 0;

            for (int i = 0; i < tableau.GetUpperBound(0); i++)
            {
                for (int j = 0; j < tableau.GetUpperBound(1); j++)
                {
                    temp = tableau[i, j];
                    somme = temp + somme;
                }

                moyenne = somme / 3;
                if (moyenne >= 80)
                {
                    a++;
                }


            }



            return a;

        }
        private void affiche(int[,] tableau)
        {

            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                string chaine = "";
                for (int colonne = 0; colonne <= tableau.GetUpperBound(1); colonne++)
                {
                    chaine = chaine + tableau[ligne, colonne].ToString().PadRight(6, ' ');
                }
                lst.Items.Add(chaine);
            }
        }

        private void btnDiagonaleAZero_Click(object sender, EventArgs e)
        {
            int[,] tableau = { { 2, -4, 3, 5 }, { 6, 5, 3, 1 }, { 8, 7, 3, 5 }, { 2, 3, 7, -3 } };
            affiche(tableau);
            metDiagonaleAZero(tableau);
            affiche(tableau);
        }
        private void metDiagonaleAZero(int[,] tableau)
        {
            int i;
            int j = 3;

            for (i = 0; i < tableau.GetLength(0); i++)
            {

                tableau[i, i] = 0;
                tableau[i, j] = 0;
                j--;
            }

        }
        private int PlusGrandNombre(int[,] tableau)
        {
            int temp = 0;
            int grand = 0;

            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    temp = tableau[i, j];
                    if (temp > grand)
                    {
                        grand = temp;

                    }

                }
            }
            return grand;
        }
        private void btnPlusGrandNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le plus grand est : " + PlusGrandNombre(tableau));
        }
    }
}
