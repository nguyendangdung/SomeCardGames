using SomeCardGamesAPI.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

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
        /// The event called when this card box is clicked on.
        /// </summary>
        public event EventHandler<Point> EventClick;

        /// <summary>
        /// How wide and tall this is.
        /// </summary>
        public Size Size;

        /// <summary>
        /// The top left corner of this.
        /// </summary>
        public Point Location;

        /// <summary>
        /// If true, the draw method will try to draw the Image.
        /// </summary>
        public bool Visible = true;

        /// <summary>
        /// This determines when this card box should be drawn in relations to other card boxes.
        /// </summary>
        public int DrawOrder = 0;

        //Methods

        /// <summary>
        /// A constructor for the CardBox class.
        /// </summary>
        /// <param name="old"></param>
        public CardBox(CardBox old)
        { 
            try
            {
                this.Image = old.Image;
                this.Size = old.Size;
                this.Location = old.Location;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// The constructor for the CardBox class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="size"></param>
        /// <param name="TopLeft"></param>
        /// <param name="TheForm">The form to draw on.</param>
        public CardBox(Bitmap image, Size size, Point TopLeft, object TheForm)
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
                if (this.Visible)
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

        /// <summary>
        /// Used by this class to handle the click event.
        /// </summary>
        /// <param name="Click"></param>
        public void OnClick(Point Click)
        {
            try
            {
                EventHandler<Point> handler = EventClick;
                handler(this, Click);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}