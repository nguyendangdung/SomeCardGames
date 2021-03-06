﻿using System.Drawing;

namespace SomeCardGamesAPI.API
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

        /// <summary>
        /// Does some startup logic. Must be called before draw is called for the first time.
        /// </summary>
        /// <param name="Game"></param>
        void StartUp(object Game);
    }
}