using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Error;

namespace SomeCardGames.Drawing.Drawers
{
    /// <summary>
    /// Draws the graphics for the Golf card game.
    /// </summary>
    public class GolfDrawer : IDrawer
    {
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
            Current = G;
            this.DrawStackInTheMiddle();
        }

        /// <summary>
        /// Draws the stack of cards in the middle of the screen.
        /// </summary>
        public void DrawStackInTheMiddle()
        {

        }
    }
}