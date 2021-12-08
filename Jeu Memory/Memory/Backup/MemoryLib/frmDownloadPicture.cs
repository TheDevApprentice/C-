using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace MemoryLib
{
    /// ------------------------------------------------------------------------------
    /// <summary>
    /// This form is used to download the pictures...
    /// </summary>
    /// ------------------------------------------------------------------------------
    internal partial class frmDownloadPicture : Form
    {
        private string _imageFolder = @"Tmp\";

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Create a new frmDownloadPicture object.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public frmDownloadPicture()
        {
            this.InitializeComponent();
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Get the image folder.
        /// </summary>
        /// ------------------------------------------------------------------------------
        public string ImageFolder
        {
            get { return this._imageFolder; }
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Download the pictures...
        /// </summary>
        /// <param name="membersId"> The pictures to download. </param>
        /// <returns> The path where the picture are saved. </returns>
        /// ------------------------------------------------------------------------------
        public void DownloadPictureASync(int[] membersId)
        {
            //this.Refresh();
            this.pgrBar.Maximum = membersId.Length;
            Thread thread = new Thread(new ParameterizedThreadStart(this.CreateDirectoryWithThumbnail));
            thread.Start(membersId);
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Download the pictures...
        /// </summary>
        /// <remarks> 
        /// The pictures should normally be saved in the user documents and not in
        /// the application directory !</remarks>
        /// <param name="mIds"> The ids to download. </param>
        /// <returns> The path where the pictures are saved. </returns>
        /// ------------------------------------------------------------------------------
        private void CreateDirectoryWithThumbnail(object mIds)
        {
            const int IMGSIZE = 130;
            int[] membersIds = mIds as int[];

            if (membersIds != null)
            {
                if (Directory.Exists(this._imageFolder)) Directory.Delete(this._imageFolder, true);
                Directory.CreateDirectory(this._imageFolder);

                using (WebClient wClient = new WebClient())
                {
                    foreach (int membersId in membersIds)
                    {
                        string path = string.Format(@"http://www.codes-sources.com/gdi/u/{0}.cs.jpg", membersId);
                        using (Image avatar = this.FixedSize(Image.FromStream(wClient.OpenRead(path)), IMGSIZE, IMGSIZE, Color.Black))
                        {
                            avatar.Save(String.Format("{0}.jpg", Path.Combine(this._imageFolder, membersId.ToString())));
                        }
                        this.lblCurrentPicture.Invoke(new EventHandler(delegate(object o, EventArgs e) { this.lblCurrentPicture.Text = String.Format("Downloading CS id {0}...", membersId); }));
                        this.pgrBar.Invoke(new EventHandler(delegate(object o, EventArgs e) { this.pgrBar.Increment(1); }));
                    }
                }
            }
            this.Invoke(new EventHandler(delegate(object o, EventArgs e) { this.Close(); }));
        }

        /// ------------------------------------------------------------------------------
        /// <summary>
        /// Resize an image.
        /// </summary>
        /// <remarks> 
        /// Found on CodeProject:
        /// http://www.codeproject.com/csharp/imageresize.asp
        /// </remarks>
        /// <param name="imgPhoto"> The picture to resize. </param>
        /// <param name="Width"> The new width. </param>
        /// <param name="Height"> The new height. </param>
        /// <returns> The new resized image. </returns>
        /// ------------------------------------------------------------------------------
        private Image FixedSize(Image imgPhoto, int width, int height, Color color)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)width / (float)sourceWidth);
            nPercentH = ((float)height / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = Convert.ToInt16((width - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = Convert.ToInt16((height - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            using (Graphics grPhoto = Graphics.FromImage(bmPhoto))
            {
                grPhoto.Clear(color);
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHeight),
                    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                    GraphicsUnit.Pixel);
            }

            imgPhoto.Dispose();
            imgPhoto = null;
            // Return the picture
            return bmPhoto;
        }
    }
}