using System;
using System.Drawing;
using System.Windows.Forms;


namespace jeu_memory
{
    class Function
    {
        Effect effect = new Effect();

        public void StartGame(Timer Chrono)
        {
            Chrono.Start();
        }

        public void FillArray(PictureBox[,] arrayPicturebox, int maxline)
        {
            for (int line = 0; line <= maxline; line++)
            {
                for (int column = 0; column <= arrayPicturebox.GetUpperBound(1); column++)
                {
                    arrayPicturebox[line, column].SizeMode = PictureBoxSizeMode.StretchImage;
                    arrayPicturebox[line, column].Image = Image.FromFile(Application.StartupPath + "\\0.png");
                    arrayPicturebox[line, column].Enabled = true;

                }
            }
        }
        public void DrawImage(PictureBox[,] arrayPicturebox, int line, int column, int line1erclick, int column1erclick)
        {
            effect.effet_qui_bouge(line1erclick, column1erclick, line, column, arrayPicturebox);
            arrayPicturebox[line, column].Image = null;
            arrayPicturebox[line1erclick, column1erclick].Image = null;
            arrayPicturebox[line, column].Enabled = false;
            arrayPicturebox[line1erclick, column1erclick].Enabled = false;
        }
        public int[,] EmptyArray(int[,] arrayImageName, int Maxline)
        {
            for (int line = 0; line <= Maxline; line++)
            {
                for (int column = 0; column <= arrayImageName.GetUpperBound(1); column++)
                {
                    arrayImageName[line, column] = 0;
                }
            }
            return arrayImageName; 
        }
        public int[,] AssignationImagePictureBox(int[,] arrayImageName, int Maxline, int Menu)
        {
            Random imageRandom = new Random();
            
            while (ImageBeThere3Times(arrayImageName, Maxline) == true) // faire une fonction while qui fait que si une image revienst trois fois il relance le truc jusqu'a qu'il y en ai 2 seulement par image
            {
                for (int line = 0; line <= Maxline; line ++)
                {
                    for (int column = 0; column <= arrayImageName.GetUpperBound(1); column ++)
                    {
                        switch (Menu)
                        {
                            case 1:
                                arrayImageName[line, column] = imageRandom.Next(9, (arrayImageName.GetLength(0) * arrayImageName.GetLength(1) / 2 + 10));
                                break;
                            case 2:
                                arrayImageName[line, column] = imageRandom.Next(1, (arrayImageName.GetLength(0) * arrayImageName.GetLength(1) / 2 + 1));
                                break;
                        }
                    }
                }
            }
            return arrayImageName;
        }
        public Boolean ImageBeThere3Times(int[,] arrayImageName, int Maxline)
        {
            Boolean resultat = false;
            int numberLookedAt = arrayImageName[0, 0];

            for (int line = 0; line <= Maxline; line++)
            {
                for (int column = 0; column <= arrayImageName.GetUpperBound(1); column++)
                {
                    numberLookedAt = arrayImageName[line, column];
                    if (ThreeTimes(numberLookedAt, arrayImageName, Maxline) == false)
                    {
                        resultat = true;
                    }
                }
            }
            return resultat;
        }

        private Boolean ThreeTimes(int numberLookedAt, int[,] arrayImageName, int Maxline)
        {
            int nbTimeHaveBeenSeen = 0;
            for (int lines = 0; lines <= Maxline; lines++)
            {
                for (int column = 0; column <= arrayImageName.GetUpperBound(1); column++)
                {
                    if (numberLookedAt == arrayImageName[lines, column])
                    {
                        nbTimeHaveBeenSeen++;
                    }
                }
            }
            if (nbTimeHaveBeenSeen == 2)
            {
                return true;
            }
            else { return false; }
        }

        public void SetRandomImage(PictureBox[,] arrayPicturebox, int[,] arrayImageName, PictureBox pictureBoxClicked, ref int line, ref int column)
        {
            string PictureLocation = pictureBoxClicked.Name;

            line = int.Parse(PictureLocation.Substring(7, 1));
            column = int.Parse(PictureLocation.Substring(9, 1));

            arrayPicturebox[line, column].Image = Image.FromFile(Application.StartupPath + "\\" + arrayImageName[line, column] + ".jpg");
        }

        public void TurnCardBack(PictureBox[,] arrayPicturebox, int line, int column, int line1erclick, int colone1erclick)
        {
            effect.wait(1000);

            arrayPicturebox[line, column].Image = Image.FromFile(Application.StartupPath + "\\0.png");
            arrayPicturebox[line1erclick, colone1erclick].Image = Image.FromFile(Application.StartupPath + "\\0.png");
        }
        public bool SameCard(int image1, int image2)
        {
            Boolean sameCard = false;

            if (image1 == image2)
            {
                sameCard = true;
            }
            else
            {
                sameCard = false;
            }

            return sameCard;
        }

        public void StopGame(Timer Chrono)
        {
            Chrono.Stop();
        }

        public bool AskTryagain(int clickToDisplay, double timerMinutes, double timerSeconds)
        {
            string message = "Want to play again ?\n" +
                "you made it in " + clickToDisplay + " clicks, and " + String.Format("0{0} min : {1} sec", timerMinutes, timerSeconds);
            string title = "Wanna try again "; 
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                EndGame();
            }
            else
            {
                
            }
            return false;
        }

        public void EndGame()
        {
            System.Windows.Forms.Application.Exit();
        }

        internal void StartGame(Func<PictureBox[,]> assignationImagePictureBox, Timer chrono)
        {
            throw new NotImplementedException();
        }
    }
}
