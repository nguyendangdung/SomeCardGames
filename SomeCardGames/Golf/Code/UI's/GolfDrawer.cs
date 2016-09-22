using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Golf.Code.UIs;
using SomeCardGamesAPI.API;
using SomeCardGamesAPI.API.Controls.UI;
using SomeCardGamesAPI.Error;

namespace Golf.Code.UI_s
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

        /// <summary>
        /// The main UI for when the player is playing golf.
        /// </summary>
        public MainUI MainGolfUI;

        /// <summary>
        /// Holds all of the UIs this drawer is responsible for drawing.
        /// </summary>
        public List<UI> UIs = new List<UI>();

        /// <summary>
        /// Called by the paint event on the form. Draws the current status of the golf card game.
        /// </summary>
        /// <param name="G"></param>
        public void Draw(Graphics G)
        {
            try
            {
                Current = G;

                foreach (UI item in this.UIs)
                {
                    item.DrawAll(G);
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
                MainGolfUI = new MainUI(true, this.Game);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}