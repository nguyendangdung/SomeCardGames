﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Base
{
    /// <summary>
    /// Represents a deck of cards in the game.
    /// </summary>
    public class Deck
    {
        private Random rng = new Random();

        public List<Card> Cards;
        /// <summary>
        /// The constructor for the Deck class. This automatically shuffles the deck.
        /// </summary>
        public Deck(bool WithJokers)
        {
            Cards = new List<Card>();
            this.AddCards(WithJokers);
            this.Shuffle();
        }

        /// <summary>
        /// Adds all of the cards into the deck.
        /// </summary>
        /// <param name="WithJokers"></param>
        public void AddCards(bool WithJokers)
        {
            int i = 0;
            int stop;

            if (WithJokers)
            {
                stop = 53;
            }
            else
            {
                stop = 51;
            }

            while (i != stop)
            {
                Cards.Add(new Card(i));
            }
        }

        /// <summary>
        /// Shuffles the deck.
        /// </summary>
        public void Shuffle()
        {
            int n = this.Cards.Count;
            int k;
            while (n > 1)
            {
                n--;
                k = rng.Next(n + 1);
                Card value = this.Cards[k];
                this.Cards[k] = this.Cards[n];
                this.Cards[n] = value;
            }
        }
    }
}