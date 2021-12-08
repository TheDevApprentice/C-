using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

/*************************************************************************************
 *
 *  CardsCollection
 *  Author : Bidou (http://www.csharpfr.com/auteurdetail.aspx?ID=13319)
 *  Blog   : http://blogs.developpeur.org/bidou/
 *  Date   : February 2007
 * 
 *************************************************************************************/

namespace MemoryLib
{
    /// ------------------------------------------------------------------------------
    /// <summary>
    /// Represents a collection of cards.
    /// </summary>
    /// ------------------------------------------------------------------------------
    internal class CardsCollection : List<Card>, IDisposable
    {
        private readonly static Random _rand = new Random();
        private static Size _imageSize = Size.Empty;

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a new CardsCollection object.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public CardsCollection()
        {
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Shuffle the current collection.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void Shuffle()
        {
            Shuffle(this);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// ------------------------------------------------------------------------------
        public static void Shuffle(List<Card> array)
        {
            int arrayLength = array.Count;

            for (int i = arrayLength - 1; i > 1; --i)
            {
                int randomIndex = _rand.Next(i);
                Card temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Return the size of an image.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public static Size ImageSize
        {
            get { return _imageSize; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a collection of cards.
        /// </summary>
        /// <param name="path"> The path where the picture are saved. </param>
        /// <param name="csMembersId"> The members id. </param>
        /// <param name="count"> The number of cards to generate. </param>
        /// <returns> A collection of cards. </returns>
        /// ------------------------------------------------------------------------------
        public static CardsCollection Load(string path, int[] csMembersId, int count)
        {
            bool pathIsInvalid = string.IsNullOrEmpty(path);
            if (count > 0)
            {
                // both are invalid
                if (pathIsInvalid && csMembersId == null) throw new ArgumentException("path is not valid and members is null");
                // Both valid or path valid
                else if (pathIsInvalid)
                {
                    using (frmDownloadPicture frmDownload = new frmDownloadPicture())
                    {
                        frmDownload.DownloadPictureASync(csMembersId);
                        frmDownload.ShowDialog();
                        path = frmDownload.ImageFolder;
                    }
                }
                return Load(path, count);
            }
            return null;
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a collection of cards.
        /// </summary>
        /// <param name="path"> The path where the picture are saved. </param>
        /// <param name="count"> The number of cards to generate. </param>
        /// <returns> A collection of cards. </returns>
        /// ------------------------------------------------------------------------------
        private static CardsCollection Load(string path, int count)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("path is not valid");

            string[] imagesName = null;
            if (Directory.Exists(path)) imagesName = Directory.GetFiles(path, "*.jpg");
            if (imagesName == null || imagesName.Length < 1) return null;

            int differentCard = count / 2;
            if (differentCard > imagesName.Length) throw new ArgumentException("Not enough images in the directory !");

            CardsCollection cards = new CardsCollection();
            List<int> choosen = new List<int>();

            for (int i = 0; i < differentCard; i++)
            {
                int randNb = 0;
                do
                {
                    randNb = _rand.Next(0, imagesName.Length);
                }
                while (choosen.Contains(randNb));
                choosen.Add(randNb);
                cards.Add(new Card(i, Image.FromFile(imagesName[randNb])));
                cards.Add(new Card(i, Image.FromFile(imagesName[randNb])));
            }
            if(cards != null && cards.Count > 0) _imageSize = cards[0].Image.Size;
            return cards;
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Dispose the CardsCollection.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public void Dispose()
        {
            foreach (Card card in this) card.Dispose();
        }
    }
}