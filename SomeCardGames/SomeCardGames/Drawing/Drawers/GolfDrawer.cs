using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Base;
using SomeCardGames.Card_Game_Module.Golf;
using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames.Drawing.Drawers
{
    /// <summary>
    /// Draws the graphics for the Golf card game.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
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
        /// Gives us a handle to the current graphics object, used to draw.
        /// </summary>
        public Graphics Current;

        /// <summary>
        /// The logic for the game is accessible through this object.
        /// </summary>
        public GolfLogic Game;

        /// <summary>
        /// Called by the paint event on the form. Draws the current status of the golf card game.
        /// </summary>
        /// <param name="G"></param>
        public void Draw(Graphics G)
        {
            try
            {
                Current = G;

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
            try
            {
                if (this.Game.TheDeck.Cards.Count > 0)
                {
                    this.CenterDeck.Location = new Point(VariableStorage.ScreenWidth / 4, VariableStorage.ScreenHeight / 4);
                    this.CenterDeck.Visible = true;
                }
                else
                {
                    this.CenterDeck.Visible = false;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Does some startup logic.
        /// </summary>
        /// <param name="Game"></param>
        public void StartUp(object Game)
        {
            try
            {
                this.Game = (GolfLogic)Game;
                this.CenterDeck = new CardPictureBox(LoadedCardResources.GetBack(), CardWidth, CardHeight);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}