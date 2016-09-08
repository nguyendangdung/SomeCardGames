using System;
using System.Drawing;
using System.Windows.Forms;

using SomeCardGamesAPI.Error;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// This is used to render a card, and to interpret different input events.
    /// </summary>
    public class CardPictureBox : PictureBox
    {
        /// <summary>
        /// For cards only, this is the back of the card.
        /// </summary>
        private Bitmap Back;

        /// <summary>
        /// Used if you want to draw something besides a card with this. This also resizes the bitmap to the specified size.
        /// </summary>
        /// <param name="Card"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public CardPictureBox(int Card, int Width, int Height)
        {
            this.LoadCardImage(Card);
            this.LoadBack();
            Image = this.TrimBitmap((Bitmap)Image, Height, Width);
            Back = this.TrimBitmap(Back, Height, Width);
            this.MouseClick += CardPictureBox_MouseClick;
        }

        /// <summary>
        /// Called when this picture box is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        /// <summary>
        /// Used if you want to draw something besides a card with this. This also resizes the bitmap to the specified size.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public CardPictureBox(Bitmap image, int Width, int Height)
        {
            try
            {
                Image = image;
                Image = this.TrimBitmap((Bitmap)Image, Height, Width);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// When this is called, it draws this card as specified.
        /// </summary>
        /// <param name="FaceUp"></param>
        /// <param name="g"></param>
        /// <param name="Location"></param>
        public void Draw(bool FaceUp, Graphics g, Point Location)
        {
            try
            {
                if (FaceUp)
                {
                    g.DrawImage(this.Image, Location);
                }
                else
                {
                    g.DrawImage(this.Back, Location);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Shrinks a bitmap to the specified size.
        /// </summary>
        /// <param name="bits"></param>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        public Bitmap TrimBitmap(Bitmap bits, int Height, int Width)
        {
            return new Bitmap(bits, new Size(Width, Height));
        }

        /// <summary>
        /// Loads what the back side of the card looks like into a bitmap.
        /// </summary>
        public void LoadBack()
        {
            this.Back = LoadedCardResources.GetBack();
        }

        /// <summary>
        /// Loads the card image from this game's resources.
        /// </summary>
        /// <param name="Card"></param>
        public void LoadCardImage(int Card)
        {
            try
            {
                this.Image = LoadedCardResources.GetResource(Card);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}