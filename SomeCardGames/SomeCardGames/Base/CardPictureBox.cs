using SomeCardGames.Error;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// The constructor for the CardPictureBox class.
        /// </summary>
        public CardPictureBox(int Card)
        {
            try
            {

            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
        /// <summary>
        /// Used if you want to draw something besides a card with this.
        /// </summary>
        /// <param name="image"></param>
        public CardPictureBox(Bitmap image)
        {
            try
            {
                Image = image;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}