using System;
using System.Windows.Forms;

namespace jeu_memory
{
    class Effect
    {
        public void wait(long millisec_a_attendre)
        {
            double end_Wait;
            end_Wait = Environment.TickCount + millisec_a_attendre;
            while (Environment.TickCount < end_Wait)
            {
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        public void effet_qui_bouge(int lignePremier, int colonnePremier, int ligneDeuxieme, int colonneDeuxieme, PictureBox[,] arrayPictureBox)
        {
            int Grosseur;
            Grosseur = 5;
            for (int cpt = 0; cpt <= 5; cpt++)
            {
                arrayPictureBox[lignePremier, colonnePremier].Height = arrayPictureBox[lignePremier, colonnePremier].Height + Grosseur;
                arrayPictureBox[lignePremier, colonnePremier].Width = arrayPictureBox[lignePremier, colonnePremier].Width + Grosseur;
                arrayPictureBox[ligneDeuxieme, colonneDeuxieme].Height = arrayPictureBox[ligneDeuxieme, colonneDeuxieme].Height + Grosseur;
                arrayPictureBox[ligneDeuxieme, colonneDeuxieme].Width = arrayPictureBox[ligneDeuxieme, colonneDeuxieme].Width + Grosseur;
                wait(100);
                Grosseur = -Grosseur;
            }
        }
    }
}
