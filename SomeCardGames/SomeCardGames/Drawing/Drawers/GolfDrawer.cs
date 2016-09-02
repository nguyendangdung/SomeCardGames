using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Base;
using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames.Drawing.Drawers
{
    /// <summary>
    /// Draws the graphics for the Golf card game.
    /// </summary>
    public class GolfDrawer : IDrawer
    {
        /// <summary>
        /// The width to make all cards to.
        /// </summary>
        public int CardWidth = Convert.ToInt32(LoadedCardResources.GetBack().Width * VariableStorage.CardScaleFactor);

        /// <summary>
        /// The width to make all cards to.
        /// </summary>
        public int CardHeight = Convert.ToInt32(LoadedCardResources.GetBack().Height * VariableStorage.CardScaleFactor);

        /// <summary>
        /// Represents the stack of cards in the middle of the screen.
        /// </summary>
        public CardPictureBox CenterDeck;

        /// <summary>
        /// Tells us if we have done startup logic yet.
        /// </summary>
        bool HasStartedUp = false;

        /// <summary>
        /// Gives us a handle to the current graphics object, used to draw.
        /// </summary>
        Graphics Current;

        /// <summary>
        /// Called by the paint event on the form. Draws the current status of the golf card game.
        /// </summary>
        /// <param name="G"></param>
        public void Draw(Graphics G)
        {
            try
            {
                Current = G;

                if (!this.HasStartedUp)
                {
                    this.StartUp();
                }

                this.DrawStackInTheMiddle();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Draws the stack of cards in the middle of the screen.
        /// </summary>
        public void DrawStackInTheMiddle()
        {
            
        }

        private void StartUp()
        {
            try
            {
                this.HasStartedUp = true;
                this.CenterDeck = new CardPictureBox(LoadedCardResources.GetBack(), CardWidth, CardHeight);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}