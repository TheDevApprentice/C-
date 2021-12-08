using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wa_tableau2dim
{
    class CarreeMagique
    {

        public Boolean verifieLigne(int[,] tableau, ref int sommeLigne)
        {
            int ligne = 0;
            Boolean reponse = false;
            sommeLigne = calculLigne(tableau, ligne);
            while (ligne <= tableau.GetUpperBound(0) && sommeLigne == calculLigne(tableau, ligne))
         {
                ligne = ligne + 1;
            }
           if (ligne - 1 == tableau.GetUpperBound(0) && sommeLigne == calculLigne(tableau, ligne - 1))
           {
              reponse = true;
           }

            return reponse;
        }
        private int calculLigne(int[,] tableau, int ligne)
        {
            int somme;
            somme = 0;
            for (int colonne = 0; colonne <= tableau.GetUpperBound(1); colonne++)
            {
                somme = somme + tableau[ligne,colonne] ;
            }
            return somme;
        }
    
        public Boolean verifieColonne(int[,] tableau, ref int sommeColonne)
        {
            int colonne = 0;
            Boolean reponse = false;
           sommeColonne = calculColonne(tableau, colonne);
            while (colonne <= tableau.GetUpperBound(0) && sommeColonne == calculColonne(tableau, colonne))
            {
                colonne = colonne + 1;
            }
          if (colonne - 1 == tableau.GetUpperBound(0) && sommeColonne == calculColonne(tableau, colonne - 1))
            {
              reponse = true;
            }
            return reponse;
        }
        public Boolean verifieDiagonale(int[,] tableau, ref int sommeDiagonaleDroite)
        {
            int sommeDiagonaleGauche = 0;
            Boolean reponse = false;

            int colonne = tableau.GetUpperBound(0);
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                sommeDiagonaleDroite = sommeDiagonaleDroite + tableau[ligne, colonne];
                colonne = colonne - 1;
            }

            // mettre code pour vérifier la diagonale droite

            colonne = tableau.GetUpperBound(0);
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                sommeDiagonaleGauche = sommeDiagonaleGauche + tableau[ligne, colonne];
                colonne = colonne - 1;
            }

            if (sommeDiagonaleDroite == sommeDiagonaleGauche)
            {
                reponse = true;
            }
            return reponse;
        }
        private int calculColonne(int[,] tableau, int colonne)
        {
            // fait la somme des éléments d'une colonne

            int somme;
            somme = 0;
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                somme = somme + tableau[ligne, colonne];
            }
            return somme;
        }

        public Boolean TousNombresPresents1Fois(int[,] tableau)
        {

            Boolean resultat = true;
            int nombreRegarder = tableau[0, 0];
            for (int ligne = 0; ligne <= tableau.GetUpperBound(0); ligne++)
            {
                for (int colonne = 0; colonne <= tableau.GetUpperBound(1); colonne++)
                {
                    nombreRegarder = tableau[ligne, colonne];
                    if (uneFois(nombreRegarder, tableau) == false)
                    {
                        resultat = false;
                    }
                }
            }
            return resultat;
        }

        private Boolean uneFois(int nombreRegarder, int[,] tableau)
        {
            int compteurNbfoisNombrevu = 0;
            for (int lignes = 0; lignes <= tableau.GetUpperBound(0); lignes++)
            {
                for (int colones = 0; colones <= tableau.GetUpperBound(1); colones++)
                {
                    if (nombreRegarder == tableau[lignes, colones])
                    {
                        compteurNbfoisNombrevu++;
                    }
                }
            }
            if (compteurNbfoisNombrevu == 1)
            {
                return true;
            }
            else { return false; }
        }
    }
}
