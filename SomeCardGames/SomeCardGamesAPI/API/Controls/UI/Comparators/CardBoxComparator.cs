using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGamesAPI.API.Controls.UI.Comparators
{
    /// <summary>
    /// This class is used to compare the draw order of CardBox, used by lists.
    /// </summary>
    public class CardBoxComparator : IComparer<CardBox>
    {
        /// <summary>
        /// Actually compares two CardBox objects.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(CardBox x, CardBox y)
        {
            try
            {
                return x.DrawOrder - y.DrawOrder;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return 0;
            }
        }
    }
}