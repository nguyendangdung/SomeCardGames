using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomeCardGames.Base;
using SomeCardGames.Error;

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