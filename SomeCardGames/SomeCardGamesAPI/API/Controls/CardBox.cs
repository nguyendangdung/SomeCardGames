using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGamesAPI.Error;

namespace SomeCardGamesAPI.API.Controls
{
    /// <summary>
    /// Basically a PictureBox.
    /// </summary>
    public class CardBox
    {
        /// <summary>
        /// Holds the image this CardBox draws.
        /// </summary>
        public Bitmap Image;

        /// <summary>
        /// If true, the draw method will try to draw the Image.
        /// </summary>
        public bool Visible = true;

        /// <summary>
        /// How wide and tall this is.
        /// </summary>
        public Size Size;

        /// <summary>
        /// The top left corner of this.
        /// </summary>
        public Point Location;

        /// <summary>
        /// The constructor for the CardBox class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="size"></param>
        /// <param name="TopLeft"></param>
        public CardBox(Bitmap image, Size size, Point TopLeft)
        {
            try
            {
                this.Image = image;
                size = Size;
                Location = TopLeft;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Draws.
        /// </summary>
        /// <param name="g">The graphics object everyone is passing around.</param>
        public void Draw(Graphics g)
        {
            try
            {
                if (Visible)
                {
                    g.DrawImage(this.Image, this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Determines if this card box was clicked on. 
        /// </summary>
        /// <param name="Click"></param>
        /// <returns></returns>
        public bool WasIClicked(Point Click)
        {
            try
            {
                if (Click.X >= this.Location.X && Click.X <= this.Location.X + this.Size.Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return true;
            }
        }
    }
}
