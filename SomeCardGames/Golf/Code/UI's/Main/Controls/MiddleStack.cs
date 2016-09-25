using SomeCardGamesAPI.API;
using SomeCardGamesAPI.API.Controls;
using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;
using System;
using System.Drawing;

namespace Golf.Code.UI_s.Main.Controls
{
    /// <summary>
    /// Represents the stack of cards in the middle of the screen.
    /// </summary>
    public class MiddleStack : CardBox
    {
        /// <summary>
        /// The current game of golf.
        /// </summary>
        public GolfLogic Game;

        /// <summary>
        /// The constructor for the MiddleStack class.
        /// </summary>
        public MiddleStack(GolfLogic GolfGame)
        {
            try
            {
                this.ConstructMe(LoadedCardResources.GetBack(), this.GetSize(), this.GetTopLeft());
                Game = GolfGame;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// The logic we do before draw is called.
        /// </summary>
        public override void PreDraw()
        {
            try
            {
                if (Game.TheDeck.GetSize() > 0)
                {
                    this.Visible = true;
                }
                else
                {
                    this.Visible = false;
                }
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