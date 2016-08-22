using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Drawing
{
    /// <summary>
    /// A interface for classes that read all sorts of information out of classes that implement ICardGame, and draw what is happening.
    /// </summary>
    public interface IDrawer
    {
        /// <summary>
        /// Called to tell a Drawer to draw the card game that they know how to draw.
        /// </summary>
        /// <param name="G"></param>
        void Draw(Graphics G);
    }
}