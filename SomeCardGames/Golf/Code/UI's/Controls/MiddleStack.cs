using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGamesAPI.API.Controls;
using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Utility;
using SomeCardGamesAPI.Error;

namespace Golf.Code.UI_s.Controls
{
    /// <summary>
    /// Represents the stack of cards in the middle of the screen.
    /// </summary>
    public class MiddleStack : CardBox
    {
        /// <summary>
        /// The constructor for the MiddleStack class.
        /// </summary>
        public MiddleStack()
        {
            try
            {
                this.ConstructMe(LoadedCardResources.GetBack(), this.GetSize(), this.GetTopLeft());
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Returns the size of this CardBox.
        /// </summary>
        /// <returns></returns>
        private Size GetSize()
        {
            try
            {
                return new Size(VariableStorage.CardWidth, VariableStorage.CardHeight);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return new Size(0, 0);
            }
        }

        /// <summary>
        /// Returns the location where we should draw the top left of this card box.
        /// </summary>
        /// <returns></returns>
        private Point GetTopLeft()
        {
            try
            {
                int X;
                int Y;

                X = (VariableStorage.ScreenWidth / 2) - this.GetSize().Width / 2;
                Y = (VariableStorage.ScreenHeight / 2) + this.GetSize().Height / 2;

                return new Point(X, Y);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return new Point(0, 0);
            }
        }
    }
}