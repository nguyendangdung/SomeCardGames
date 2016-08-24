using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames.Base
{
    /// <summary>
    /// This class is used to store bitmaps for cards.
    /// </summary>
    public static class LoadedCardResources
    {
        private static List<Bitmap> CardResources = new List<Bitmap>();

        /// <summary>
        /// Loads a bunch of resources into memory.
        /// </summary>
        /// <param name="Card"></param>
        /// <returns></returns>
        public static Bitmap GetResource(int Card)
        {
            if (CardResources.Count < 1)
            {
                CardResources.Clear();

                int i = 0;

                while (i != 55)
                {
                    i++;
                    CardResources.Add(Util.LoadResource(i.ToString() + ".png"));
                }
            }

            return CardResources.ElementAt(Card);
        }

        /// <summary>
        /// Gets what the back of the cards looks like.
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetBack()
        {
            try
            {
                return Util.LoadResource("back.png");
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }
    }
}