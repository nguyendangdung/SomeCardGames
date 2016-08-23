using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Base;
using SomeCardGames.Error;

namespace SomeCardGames.Card_Game_Module.Golf
{
    /// <summary>
    /// This class is the main source and entrance for the card game "Golf".
    /// </summary>
    public class GolfLogic : ICardGame
    {
        /// <summary>
        /// This is the deck of cards in the middle of the table.
        /// </summary>
        Deck TheDeck = new Deck(false);

        /// <summary>
        /// Called to start running this card game.
        /// </summary>
        public void Start()
        {
            TheDeck.Shuffle();
        }

        /// <summary>
        /// Called to stop this card game.
        /// </summary>
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}