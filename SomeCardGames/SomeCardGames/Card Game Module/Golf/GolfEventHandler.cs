using SomeCardGames.Base;
using System;
using System.Windows.Forms;

namespace SomeCardGames.Card_Game_Module.Golf
{
    /// <summary>
    /// This is used to recieve and process mouse and keyboard events.
    /// </summary>
    public class GolfEventHandler : IEventHandler
    {
        /// <summary>
        /// This is called when a card is clicked on.
        /// </summary>
        public void CardWasClickedOn(Card card, MouseEventArgs e)
        {
            throw new NotImplementedException(); //TODO: this
        }
    }
}