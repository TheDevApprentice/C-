using System;
using System.Windows.Forms;

namespace jeu_memory
{
    public partial class Form1 : Form
    {
        // liaison des classes

        Function function = new Function();
        Effect effet = new Effect();
        Timer timer = new Timer();

        //Instenciation globale

        PictureBox[,] arrayPicturebox = new PictureBox[4, 4];
        int[,] arrayImageNameIntermediate = new int[3, 4];
        int[,] arrayImageNameHard = new int[4, 4];


        //Global Variables

        double timerSeconds = 0;        // pour la minuterie 
        double timerMinutes = 0;

        int countImageReturned = 0;
        int countClickImage = 0;             // nombre d'essaie
        int nbTry = 0;
        int clickToDisplay = 0;

        int line1stclick = 0;          // récupération de la position
        int column1stclick = 0;
        new int Menu;                   // 1 = intermédiaire et 2 = difficile
        int MaxLine = 3;

        //boolean indispensable
        bool allCardTurned = false;

        public PictureBox[,] AssignationPictureBox()          //on attribue les images de la question
        {
            PictureBox[,] arrayPicturebox = new PictureBox[4, 4];

            arrayPicturebox[0, 0] = picboxl0e0;
            arrayPicturebox[0, 1] = picboxl0e1;
            arrayPicturebox[0, 2] = picboxl0e2;
            arrayPicturebox[0, 3] = picboxl0e3;
            arrayPicturebox[1, 0] = picboxl1e0;
            arrayPicturebox[1, 1] = picboxl1e1;
            arrayPicturebox[1, 2] = picboxl1e2;
            arrayPicturebox[1, 3] = picboxl1e3;
            arrayPicturebox[2, 0] = picboxl2e0;
            arrayPicturebox[2, 1] = picboxl2e1;
            arrayPicturebox[2, 2] = picboxl2e2;
            arrayPicturebox[2, 3] = picboxl2e3;
            arrayPicturebox[3, 0] = picboxl3e0;
            arrayPicturebox[3, 1] = picboxl3e1;
            arrayPicturebox[3, 2] = picboxl3e2;
            arrayPicturebox[3, 3] = picboxl3e3;

            return arrayPicturebox;
        }

        public Form1()
        {
            InitializeComponent();

            // affiche le nombre d'essaies
            txtNumberOfTry.Text = nbTry.ToString();

            // affiche le timer régler à 0
            string timers = String.Format("0{0} min : 0{1} sec", timerMinutes, timerSeconds);
            txtTimer.Text = timers.ToString();

            txtClickNumberToDisplay.Text = clickToDisplay.ToString();

            string title = "Bienvenu ! ";
            string message = "Bienvenu dans le jeux !\n" + "c'est un jeu fait à partir de rien ! J'espère que ca va vous plaire !\n" +
             "Pour jouer à ce jeux, choissisez un niveau de difficulté dans le coin en bas à gauche !\n" +
             "Ensuite juste cliquez sur Start ! Bon jeux !";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);

        }
        public void Form1_Load_1(object sender, EventArgs e)
        {

        }

        public void BtnStartChrono_Click(object sender, EventArgs e)
        {
            function.StartGame(Chrono);
           
        }

        private void Chrono_Tick(object sender, EventArgs e)
        {
            if (timerSeconds == 60)
            {
                timerMinutes++;
            }
            else { timerSeconds++; }

            string timers = String.Format("0{0} min : {1} sec", timerMinutes, timerSeconds);
            txtTimer.Text = timers.ToString();
        }

        public void Picboxl1e1_Click(object sender, EventArgs e)
        {
            int line = 0;
            int column = 0;

            clickToDisplay++;
            txtClickNumberToDisplay.Text = clickToDisplay.ToString();
            countClickImage++;

            PictureBox pictureBoxClick = (PictureBox)sender;
            string PictureLocation = pictureBoxClick.Name;
            //MessageBox.Show(PictureLocation);

            switch (Menu)
            {
                case 1:
                    function.SetRandomImage(arrayPicturebox, arrayImageNameIntermediate, pictureBoxClick, ref line, ref column);
                    break;

                case 2:
                    function.SetRandomImage(arrayPicturebox, arrayImageNameHard, pictureBoxClick, ref line, ref column);
                    break;
            }

            if (countClickImage == 1)
            {
                line1stclick = line;
                column1stclick = column;
            }
            
            else //deuxième click
            {
                switch (Menu)
                {
                    case 1:

                        if (function.SameCard(arrayImageNameIntermediate[line, column], arrayImageNameIntermediate[line1stclick, column1stclick]) == true)
                        {
                            function.DrawImage(arrayPicturebox, line, column, line1stclick, column1stclick); // mettre le point image à null
                            progressBar1.Increment(3);
                            countImageReturned += 2;
                            countClickImage = 0;

                            while (countImageReturned == arrayImageNameIntermediate.Length)
                            {
                                allCardTurned = true;

                                countImageReturned = 0;
                                countClickImage = 0;
                            }
                        }
                        else
                        {
                            countClickImage = 0;
                            function.TurnCardBack(arrayPicturebox, line, column, line1stclick, column1stclick);
                        }
                        break;

                    case 2:

                        if (function.SameCard(arrayImageNameHard[line, column], arrayImageNameHard[line1stclick, column1stclick]) == true)
                        {
                            function.DrawImage(arrayPicturebox, line, column, line1stclick, column1stclick); // mettre le point image à null
                            progressBar1.Increment(2);
                            countImageReturned += 2;
                            countClickImage = 0;

                            while (countImageReturned == arrayImageNameHard.Length)
                            {
                                allCardTurned = true;

                                countImageReturned = 0;
                                countClickImage = 0;
                            }
                        }
                        else
                        {
                            countClickImage = 0;
                            function.TurnCardBack(arrayPicturebox, line, column, line1stclick, column1stclick);
                        }
                        break;
                }
                if (allCardTurned == true)
                {
                    function.StopGame(Chrono);

                    string timers = String.Format("0{0} min : {1} sec", timerMinutes, timerSeconds);
                    txtTimer.Text = timers.ToString();
                    switch (Menu)
                    {
                        case 1:
                            function.EmptyArray(arrayImageNameIntermediate, MaxLine);
                            function.AssignationImagePictureBox(arrayImageNameIntermediate, MaxLine, Menu);
                            arrayPicturebox = AssignationPictureBox();
                            
                            break;

                        case 2:
                            function.EmptyArray(arrayImageNameHard, MaxLine);
                            function.AssignationImagePictureBox(arrayImageNameHard, MaxLine, Menu);
                            arrayPicturebox = AssignationPictureBox();

                            break;
                    }

                    if (function.AskTryagain(clickToDisplay,timerMinutes, timerSeconds) == false)
                    {
                        MessageBox.Show("lets gooo !");

                        allCardTurned = false;

                        PictureBox[,] arrayImagePicturebox = new PictureBox[4, 4];

                        arrayImagePicturebox = AssignationPictureBox();
                        function.FillArray(arrayImagePicturebox, MaxLine);

                    
                        function.StartGame(Chrono);
                        nbTry++;
                        txtNumberOfTry.Text = nbTry.ToString();
                        clickToDisplay = 0;
                        txtClickNumberToDisplay.Text = clickToDisplay.ToString();
                        timerSeconds = 0;
                        timerMinutes = 0;
                        progressBar1.Value = 0;
                    }
                    else { function.EndGame(); }
                }
            }
        }

        private void mnstripchoiceDifficile_Click(object sender, EventArgs e)
        {
            Chrono.Stop();
            timerSeconds = 0;
            timerMinutes = 0;
            Menu = 2;
            MaxLine = 3;
            function.AssignationImagePictureBox(arrayImageNameHard, MaxLine, Menu);
            arrayPicturebox = AssignationPictureBox();
            function.FillArray(arrayPicturebox, MaxLine);
            btnStartChrono.Enabled = true;
            picboxl3e0.Visible = true;
            picboxl3e1.Visible = true;
            picboxl3e2.Visible = true;
            picboxl3e3.Visible = true;
        }

        private void mnstripchoiceIntermediaire_Click(object sender, EventArgs e)
        {
            Chrono.Stop();
            timerSeconds = 0;
            timerMinutes = 0;
            Menu = 1; 
            MaxLine = 2;
            function.AssignationImagePictureBox(arrayImageNameIntermediate, MaxLine, Menu);
            arrayPicturebox = AssignationPictureBox();
            function.FillArray(arrayPicturebox, MaxLine);
            btnStartChrono.Enabled = true;

            picboxl3e0.Visible = false;
            picboxl3e1.Visible = false;
            picboxl3e2.Visible = false;
            picboxl3e3.Visible = false;
        }


    }
}
