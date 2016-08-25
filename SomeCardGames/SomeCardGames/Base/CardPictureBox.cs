using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames.Base
{
    /// <summary>
    /// This is used to render a card, and to interpret different input events.
    /// </summary>
    public class CardPictureBox
    {
        /// <summary>
        /// The image of this picture box.
        /// </summary>
        private Bitmap Image;

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
            Image = this.TrimBitmap(Image, Height, Width);
            Back = this.TrimBitmap(Back, Height, Width);
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
                Image = this.TrimBitmap(Image, Height, Width);
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