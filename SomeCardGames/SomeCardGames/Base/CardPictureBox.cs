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
        /// <param name="TopLeft"></param>
        /// <param name="BottomRight"></param>
        public void Draw(bool FaceUp, Graphics g, Point Location)
        {
            if (FaceUp)
            {
                g.DrawImage(this.Image, Location);
            }
            else
            {

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
            this.Back = Util.LoadResource("back.png");
        }

        /// <summary>
        /// Loads the card image from this game's resources.
        /// </summary>
        /// <param name="Card"></param>
        public void LoadCardImage(int Card)
        {
            try
            {
                switch (Card)
                {
                    case 0:
                        this.Image = Util.LoadResource("50.png");
                        break;
                    case 1:
                        this.Image = Util.LoadResource("46.png");
                        break;
                    case 2:
                        this.Image = Util.LoadResource("42.png");
                        break;
                    case 3:
                        this.Image = Util.LoadResource("38.png");
                        break;
                    case 4:
                        this.Image = Util.LoadResource("34.png");
                        break;
                    case 5:
                        this.Image = Util.LoadResource("30.png");
                        break;
                    case 6:
                        this.Image = Util.LoadResource("26.png");
                        break;
                    case 7:
                        this.Image = Util.LoadResource("22.png");
                        break;
                    case 8:
                        this.Image = Util.LoadResource("18.png");
                        break;
                    case 9:
                        this.Image = Util.LoadResource("14.png");
                        break;
                    case 10:
                        this.Image = Util.LoadResource("10.png");
                        break;
                    case 11:
                        this.Image = Util.LoadResource("6.png");
                        break;
                    case 12:
                        this.Image = Util.LoadResource("2.png");
                        break;
                    case 13:
                        this.Image = Util.LoadResource("49.png");
                        break;
                    case 14:
                        this.Image = Util.LoadResource("45.png");
                        break;
                    case 15:
                        this.Image = Util.LoadResource("41.png");
                        break;
                    case 16:
                        this.Image = Util.LoadResource("37.png");
                        break;
                    case 17:
                        this.Image = Util.LoadResource("33.png");
                        break;
                    case 18:
                        this.Image = Util.LoadResource("29.png");
                        break;
                    case 19:
                        this.Image = Util.LoadResource("25.png");
                        break;
                    case 20:
                        this.Image = Util.LoadResource("21.png");
                        break;
                    case 21:
                        this.Image = Util.LoadResource("17.png");
                        break;
                    case 22:
                        this.Image = Util.LoadResource("13.png");
                        break;
                    case 23:
                        this.Image = Util.LoadResource("9.png");
                        break;
                    case 24:
                        this.Image = Util.LoadResource("5.png");
                        break;
                    case 25:
                        this.Image = Util.LoadResource("1.png");
                        break;
                    case 26:
                        this.Image = Util.LoadResource("51.png");
                        break;
                    case 27:
                        this.Image = Util.LoadResource("47.png");
                        break;
                    case 28:
                        this.Image = Util.LoadResource("43.png");
                        break;
                    case 29:
                        this.Image = Util.LoadResource("39.png");
                        break;
                    case 30:
                        this.Image = Util.LoadResource("35.png");
                        break;
                    case 31:
                        this.Image = Util.LoadResource("31.png");
                        break;
                    case 32:
                        this.Image = Util.LoadResource("27.png");
                        break;
                    case 33:
                        this.Image = Util.LoadResource("23.png");
                        break;
                    case 34:
                        this.Image = Util.LoadResource("19.png");
                        break;
                    case 35:
                        this.Image = Util.LoadResource("15.png");
                        break;
                    case 36:
                        this.Image = Util.LoadResource("11.png");
                        break;
                    case 37:
                        this.Image = Util.LoadResource("7.png");
                        break;
                    case 38:
                        this.Image = Util.LoadResource("3.png");
                        break;
                    case 39:
                        this.Image = Util.LoadResource("52.png");
                        break;
                    case 40:
                        this.Image = Util.LoadResource("48.png");
                        break;
                    case 41:
                        this.Image = Util.LoadResource("44.png");
                        break;
                    case 42:
                        this.Image = Util.LoadResource("40.png");
                        break;
                    case 43:
                        this.Image = Util.LoadResource("36.png");
                        break;
                    case 44:
                        this.Image = Util.LoadResource("32.png");
                        break;
                    case 45:
                        this.Image = Util.LoadResource("28.png");
                        break;
                    case 46:
                        this.Image = Util.LoadResource("24.png");
                        break;
                    case 47:
                        this.Image = Util.LoadResource("20.png");
                        break;
                    case 48:
                        this.Image = Util.LoadResource("16.png");
                        break;
                    case 49:
                        this.Image = Util.LoadResource("12.png");
                        break;
                    case 50:
                        this.Image = Util.LoadResource("8.png");
                        break;
                    case 51:
                        this.Image = Util.LoadResource("4.png");
                        break;
                    case 52:
                        this.Image = Util.LoadResource("54.png");
                        break;
                    case 53:
                        this.Image = Util.LoadResource("53.png");
                        break;
                    default:
                        this.Image = Util.LoadResource("back.png");
                        break;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}