using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace wfa_pair
{
    class Effet
    {
        public void attente(long millisec_a_attendre)
        {
            double Fin_Attente;
            Fin_Attente = Environment.TickCount + millisec_a_attendre;
            while (Environment.TickCount < Fin_Attente)
            {
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        public void effet_qui_bouge(int lignePremier, int colonnePremier, int ligneDeuxieme, int colonneDeuxieme, PictureBox[,] tableauPictureBox)
        {
            int Grosseur;
            Grosseur = 5;
            for (int cpt = 0; cpt <= 4; cpt++)
            {
                tableauPictureBox[lignePremier, colonnePremier].Height = tableauPictureBox[lignePremier, colonnePremier].Height + Grosseur;
                tableauPictureBox[lignePremier, colonnePremier].Width = tableauPictureBox[lignePremier, colonnePremier].Width + Grosseur;
                tableauPictureBox[ligneDeuxieme, colonneDeuxieme].Height = tableauPictureBox[ligneDeuxieme, colonneDeuxieme].Height + Grosseur;
                tableauPictureBox[ligneDeuxieme, colonneDeuxieme].Width = tableauPictureBox[ligneDeuxieme, colonneDeuxieme].Width + Grosseur;
                attente(100);
                Grosseur = -Grosseur;
            }
        }
    }
}
