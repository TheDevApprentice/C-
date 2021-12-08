using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

/*************************************************************************************
 *
 *  Memory
 *  Author : Bidou (http://www.csharpfr.com/auteurdetail.aspx?ID=13319)
 *  Blog   : http://blogs.developpeur.org/bidou/
 *  Date   : February 2007
 * 
 *************************************************************************************/

namespace MemoryLib
{
    /// ------------------------------------------------------------------------------
    /// <summary>
    /// Represents the game (GUI).
    /// </summary>
    /// ------------------------------------------------------------------------------
    public partial class Memory : UserControl
    {
        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Fired when the user win.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public event UserWinEventHandler UserWin = null;
        private const int _SPACEBETWEENCARDS = 20;

        private SolidBrush _fontBrush = new SolidBrush(Color.DarkBlue);
        private MemoryGame _memoryGame = null;
        private bool _mustWait = false;
        private int _cardsX = 4;
        private int _cardsY = 4;
        private int _currentShown = 0;

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create the memory (GUI) object.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public Memory()
        {
            this.InitializeComponent();
        }

        #region Properties

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the number of cards on the X axis.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public int CardsX
        {
            get { return this._cardsX; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the number of cards on the Y axis.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public int CardsY
        {
            get { return this._cardsY; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the number of cards.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public int CardsCount
        {
            get { return this._cardsX * this._cardsY; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set the directory where the pictures are located.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public string ImageDirectory
        {
            get { return MemoryGame.ImageDirectory; }
            set { MemoryGame.ImageDirectory = value; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set codes-sources member's to display.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public int[] CSMembersId
        {
            get { return MemoryGame.MembersId; }
            set { MemoryGame.MembersId = value; }
        }

        #endregion

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Start the game.
        /// </summary>
        /// <param name="diff"> The difficulty. </param>
        /// ------------------------------------------------------------------------------
        public void Start(Difficulty diff)
        {
            // Calling dispose on the game release the images...
            if (this._memoryGame != null)
            {
                this._memoryGame.Dispose();
                this._memoryGame = null;
                this.Refresh();
            }

            // Difficulty
            switch (diff)
            {
                case Difficulty.Novice:
                    this._cardsX = 3;
                    this._cardsY = 2;
                    break;
                case Difficulty.Average:
                    this._cardsX = 4;
                    this._cardsY = 4;
                    break;
                case Difficulty.Expert:
                    this._cardsX = 6;
                    this._cardsY = 5;
                    break;
            }

            // Create the game
            this._memoryGame = new MemoryGame(this.CardsCount);
            this._memoryGame.UserWin += new UserWinEventHandler(this.memoryGame_UserWin);
            this._memoryGame.StartGame();
            // Adjust the game's size
            this.SetSize();
            this.Invalidate();
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// The user has won.
        /// </summary>
        /// <param name="seconds"> The duration of the game. </param>
        /// ------------------------------------------------------------------------------
        private void memoryGame_UserWin(double seconds)
        {
            if (this.UserWin != null) this.UserWin(seconds);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Repaint...
        /// </summary>
        /// <param name="e"></param>
        /// ------------------------------------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this._memoryGame != null)
            {
                Rectangle rect = new Rectangle(Point.Empty, CardsCollection.ImageSize);
                for (int i = 0; i < this._cardsX; i++)
                {
                    rect.Location = new Point(_SPACEBETWEENCARDS + i * (rect.Width + _SPACEBETWEENCARDS), rect.Location.Y);
                    for (int j = 0; j < this._cardsY; j++)
                    {
                        rect.Location = new Point(rect.Location.X, _SPACEBETWEENCARDS + j * (rect.Height + _SPACEBETWEENCARDS));
                        Card card = this.GetCard(rect.Location);
                        if (card != null && !card.IsFound)
                        {
                            if (card.IsPlayed) e.Graphics.DrawImage(card.Image, rect.Location);
                            else
                            {
                                e.Graphics.FillRectangle(new LinearGradientBrush(rect, Color.AliceBlue, Color.WhiteSmoke, LinearGradientMode.BackwardDiagonal), rect);
                                e.Graphics.DrawString("CodeS-SourceS", this.Font, this._fontBrush, rect.Location);
                            }
                        }
                    }
                }
            }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Set the game's size.
        /// </summary>
        /// ------------------------------------------------------------------------------
        private void SetSize()
        {
            Size imgSize = CardsCollection.ImageSize;

            int xx = (_cardsX + 1) * _SPACEBETWEENCARDS + imgSize.Width * _cardsX;
            int yy = (_cardsY + 1) * _SPACEBETWEENCARDS + imgSize.Height * _cardsY;
            this.Size = new Size(xx, yy);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Return the card at the specified position. Null if there is not card.
        /// </summary>
        /// <param name="pt"> The point. </param>
        /// <returns> The card at this location. </returns>
        /// ------------------------------------------------------------------------------
        private Card GetCard(Point pt)
        {
            int index = this.PointToImageIndex(pt);
            return (index >= 0 ? this._memoryGame[index] : null);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the position of an image.
        /// </summary>
        /// <param name="clickedPoint"> The clicked point.</param>
        /// <returns> The position of the picture. </returns>
        /// ------------------------------------------------------------------------------
        private Point GetImagePosition(Point clickedPoint)
        {
            int xValue = -1;
            int yValue = -1;
            int spaceAndCard = (_SPACEBETWEENCARDS + CardsCollection.ImageSize.Width);

            // X
            int nbTimesX = clickedPoint.X / spaceAndCard;
            if (nbTimesX > 0)
            {
                int offsetX = clickedPoint.X % (nbTimesX * spaceAndCard);
                if (offsetX >= _SPACEBETWEENCARDS) xValue = nbTimesX;
            }
            else
            {
                if (clickedPoint.X >= _SPACEBETWEENCARDS) xValue = 0;
            }

            // Y
            int nbTimesY = clickedPoint.Y / spaceAndCard;
            if (nbTimesY > 0)
            {
                int offsetY = clickedPoint.Y % (nbTimesY * spaceAndCard);
                if (offsetY >= _SPACEBETWEENCARDS) yValue = nbTimesY;
            }
            else
            {
                if (clickedPoint.Y >= _SPACEBETWEENCARDS) yValue = 0;
            }
            return new Point(xValue, yValue);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickedPoint"></param>
        /// <returns></returns>
        /// ------------------------------------------------------------------------------
        private Rectangle GetImageRectangle(Point clickedPoint)
        {
            Point position = this.GetImagePosition(clickedPoint);
            Point pos = new Point(position.X * (_SPACEBETWEENCARDS + CardsCollection.ImageSize.Width) + _SPACEBETWEENCARDS, position.Y * (_SPACEBETWEENCARDS + CardsCollection.ImageSize.Height) + _SPACEBETWEENCARDS);
            return new Rectangle(pos, CardsCollection.ImageSize);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickedPoint"></param>
        /// <returns></returns>
        /// ------------------------------------------------------------------------------
        private Rectangle GetImageRectangle(Point cardLoc, object passNull)
        {
            Point pos = new Point(cardLoc.X * (_SPACEBETWEENCARDS + CardsCollection.ImageSize.Width) + _SPACEBETWEENCARDS, cardLoc.Y * (_SPACEBETWEENCARDS + CardsCollection.ImageSize.Height) + _SPACEBETWEENCARDS);
            return new Rectangle(pos, CardsCollection.ImageSize);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the index of an image from a point.
        /// </summary>
        /// <param name="clickedPoint"> The point.</param>
        /// <returns> The index of the picture. </returns>
        /// ------------------------------------------------------------------------------
        private int PointToImageIndex(Point clickedPoint)
        {
            Point loc = this.GetImagePosition(clickedPoint);
            if (loc.X < 0 || loc.Y < 0) return -1;
            else return (loc.X * this._cardsY + loc.Y);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// ------------------------------------------------------------------------------
        private Point ImageIndexToPoint(int index)
        {
            if (index >= 0 && index <= this.CardsCount)
            {
                int y = index % this._cardsY;
                int x = (index - y) / this._cardsY;
                return new Point(x, y);
            }
            return new Point(-1, -1);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// The user click on the game.
        /// </summary>
        /// <param name="sender"> Not used. </param>
        /// <param name="e"> Not used. </param>
        /// ------------------------------------------------------------------------------
        private void Memory_MouseClick(object sender, MouseEventArgs e)
        {
            if (this._memoryGame != null && this._memoryGame.IsGameStarted && !this._mustWait)
            {
                Card card = this.GetCard(e.Location);
                if (card != null && (!card.IsPlayed && !card.IsFound))
                {
                    Rectangle rect = this.GetImageRectangle(e.Location);
                    this._currentShown++;
                    this._memoryGame.SetPlayedCard(card);
                    this.Invalidate(rect);

                    if (this._currentShown == 2)
                    {
                        this._mustWait = true;
                        this.Invalidate(rect);
                        Application.DoEvents(); // Force refresh
                        System.Threading.Thread.Sleep(1000);
                        List<int> cardsIndex = this._memoryGame.SelectedCardsIndex;
                        this._memoryGame.CheckPairValidity();
                        this._currentShown = 0;
                        this.Invalidate(this.GetImageRectangle(this.ImageIndexToPoint(cardsIndex[0]), null));
                        this.Invalidate(this.GetImageRectangle(this.ImageIndexToPoint(cardsIndex[1]), null));
                        this._mustWait = false;
                    }
                }
            }
        }
    }
}