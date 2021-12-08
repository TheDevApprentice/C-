using System;
using System.Collections.Generic;
using System.Diagnostics;

/*************************************************************************************
 *
 *  MemoryGame
 *  Author : Bidou (http://www.csharpfr.com/auteurdetail.aspx?ID=13319)
 *  Blog   : http://blogs.developpeur.org/bidou/
 *  Date   : February 2007
 * 
 *************************************************************************************/

namespace MemoryLib
{
    public delegate void UserWinEventHandler(double seconds);

    /// ------------------------------------------------------------------------------
    /// <summary>
    /// Represents the game.
    /// </summary>
    /// ------------------------------------------------------------------------------
    internal class MemoryGame : IDisposable
    {
        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Fired when the user win.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public event UserWinEventHandler UserWin = null;
        private static string _imageDirectory = null;
        private static int[] _membersId = null;

        private int _cardsCount = 0;
        private int _foundedPairs = 0;
        private bool _isGameStarted = false;

        private Stopwatch _sWatch = new Stopwatch();
        private CardsCollection _cards = null;
        private CardsCollection _selectedCards = new CardsCollection();

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a new MemoryGame object.
        /// </summary>
        /// <param name="cardsCount"> The number of cards. </param>
        /// ------------------------------------------------------------------------------
        public MemoryGame(int cardsCount)
        {
            this._cardsCount = cardsCount;
        }

        #region Properties

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get if the game is started.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public bool IsGameStarted
        {
            get { return this._isGameStarted; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the card at the specifed index.
        /// </summary>
        /// <param name="index"> The index. </param>
        /// <returns> The card. </returns>
        /// ------------------------------------------------------------------------------
        public Card this[int index]
        {
            get { return this._cards == null ? null : this._cards[index]; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set the image's directory.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public static string ImageDirectory
        {
            get { return _imageDirectory; }
            set { _imageDirectory = value; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set the member's id to display.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public static int[] MembersId
        {
            get { return _membersId; }
            set { _membersId = value; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the selected cards.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public List<int> SelectedCardsIndex
        {
            get
            {
                List<int> indexes = new List<int>(2);
                if (this._selectedCards.Count == 2)
                {
                    indexes.Add(this._cards.IndexOf(this._selectedCards[0]));
                    indexes.Add(this._cards.IndexOf(this._selectedCards[1]));
                }
                return indexes;
            }
        }

        #endregion

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Dispose the MemoryGame.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void Dispose()
        {
            if (this._cards != null) this._cards.Dispose();
            if (this._selectedCards != null) this._selectedCards.Dispose();
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Play a card.
        /// </summary>
        /// <param name="card"> The card to play. </param>
        /// ------------------------------------------------------------------------------
        public void SetPlayedCard(Card card)
        {
            card.IsPlayed = true;
            this._selectedCards.Add(card);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Reset the played cards.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void ResetPlayedCard()
        {
            foreach (Card card in this._selectedCards) card.IsPlayed = false;
            this._selectedCards.Clear();
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Start the game.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void StartGame()
        {
            if (!string.IsNullOrEmpty(_imageDirectory) || _membersId != null)
            {
                this._cards = CardsCollection.Load(_imageDirectory, _membersId, this._cardsCount);
                this._cards.Shuffle();
                this._isGameStarted = true;
                this._sWatch.Start();
            }
            else throw new InvalidOperationException("The methode StartGame cannot be called because either _imageDirectory or _membersId is null");
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Check if two pairs are equals.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void CheckPairValidity()
        {
            if (this._selectedCards.Count == 2)
            {
                if (this._selectedCards[0].PairNb == this._selectedCards[1].PairNb && this._selectedCards[0] != this._selectedCards[1])
                {
                    this._selectedCards[0].IsFound = true;
                    this._selectedCards[1].IsFound = true;
                    this._foundedPairs++;

                    if (this._foundedPairs == this._cardsCount / 2)
                    {
                        this._sWatch.Stop();
                        this._isGameStarted = false;
                        if (this.UserWin != null) this.UserWin(Math.Round(this._sWatch.ElapsedMilliseconds/1000d, 2));
                    }
                }
                this.ResetPlayedCard();
            }
        }
    }
}