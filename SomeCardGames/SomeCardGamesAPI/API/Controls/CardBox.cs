using System;
using System.Drawing;
using System.Windows.Forms;

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

//Methods

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
                Form form = (Form)TheForm;
                form.Paint += Form_Paint;
                form.Click += Form_Click;
                
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            try
            {
                Point CursorLocation = new Point(Cursor.Position.X, Cursor.Position.Y);
                if (this.WasIClicked(CursorLocation))
                {
                    this.OnClick(CursorLocation);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Calls this class's draw method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                this.Draw(e.Graphics);
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
        private void Draw(Graphics g)
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
        private bool WasIClicked(Point Click)
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

        /// <summary>
        /// Used by this class to handle the click event.
        /// </summary>
        /// <param name="Click"></param>
        private void OnClick(Point Click)
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