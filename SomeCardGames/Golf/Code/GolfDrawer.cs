using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golf.Code
{
    /// <summary>
    /// Draws the graphics for the Golf card game.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class GolfDrawer : IDrawer
    {
        /// <summary>
        /// Gives us a handle to the current graphics object, used to draw.
        /// </summary>
        public Graphics Current;

        /// <summary>
        /// The logic for the game is accessible through this object.
        /// </summary>
        public GolfLogic Game;

        public PictureBox MiddleStack;

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
                if (Game.TheDeck.GetSize() > 0)
                {
                    this.MiddleStack.Visible = true;
                }
                else
                {
                    this.MiddleStack.Visible = false;
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

                #region MiddleStack

                this.MiddleStack = new PictureBox();
                this.MiddleStack.Location = new System.Drawing.Point(1000, 1000);
                this.MiddleStack.Name = "Pile";
                this.MiddleStack.Size = new System.Drawing.Size(2000, 2000);
                this.MiddleStack.TabStop = false;
                this.MiddleStack.Image = LoadedCardResources.GetBack();

                #endregion MiddleStack
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}