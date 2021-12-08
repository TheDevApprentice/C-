using System;
using System.Collections.Generic;
using System.Drawing;

/*************************************************************************************
 *
 *  Card
 *  Author : Bidou (http://www.csharpfr.com/auteurdetail.aspx?ID=13319)
 *  Blog   : http://blogs.developpeur.org/bidou/
 *  Date   : February 2007
 * 
 *************************************************************************************/

namespace MemoryLib
{
    /// ------------------------------------------------------------------------------
    /// <summary>
    /// Represents a card.
    /// </summary>
    /// ------------------------------------------------------------------------------
    internal class Card : IDisposable
    {
        private bool _isPlayed = false;
        private bool _isFound = false;
        private int _pairNb = 0;
        private Image _image = null;

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a card.
        /// </summary>
        /// <param name="pairNb"> The id of the card. </param>
        /// <param name="image"> The image associated to this card. </param>
        /// ------------------------------------------------------------------------------
        public Card(int pairNb, Image image)
        {
            this._image = image;
            this._pairNb = pairNb;
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Dispose the card.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void Dispose()
        {
            if (this._image != null)
            {
                this._image.Dispose();
                this._image = null;
            }
        }

        #region Properties

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the id of this card.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public int PairNb
        {
            get { return this._pairNb; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the image.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public Image Image
        {
            get { return this._image; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set if this card has been found.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public bool IsFound
        {
            get { return this._isFound;  }
            set { this._isFound = value; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get or set if this card has been played.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public bool IsPlayed
        {
            get { return this._isPlayed; }
            set { this._isPlayed = value; }
        }

        #endregion
    }
}