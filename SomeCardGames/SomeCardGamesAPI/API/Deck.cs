using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// Represents a deck of cards in the game.
    /// </summary>
    public class Deck
    {
        private Random rng = new Random();

        /// <summary>
        /// All of the cards in the deck.
        /// </summary>
        public List<Card> Cards;

        /// <summary>
        /// The constructor for the Deck class. This automatically shuffles the deck. Also adds multiple decks if DecksToAdd is greater than 1.
        /// </summary>
        public Deck(bool WithJokers, int DecksToAdd)
        {
            try
            {
                Cards = new List<Card>();

                if (DecksToAdd > 1)
                {
                    int i = 0;

                    while (i != DecksToAdd)
                    {
                        this.AddCards(WithJokers);
                        i++;
                    }
                }
                else
                {
                    this.AddCards(WithJokers);
                }
                this.Shuffle();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Returns how many cards are remaining in the deck.
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return Cards.Count;
        }

        /// <summary>
        /// Returns the top card if there is one available, and removes it from the deck. Returns null if no card available.
        /// </summary>
        /// <returns></returns>
        public Card GetTop()
        {
            try
            {
                if (this.Cards.Count < 1)
                {
                    return null;
                }
                else
                {
                    Card ret = this.Cards[0];
                    this.Cards.RemoveAt(0);
                    return ret;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Adds all of the cards into the deck.
        /// </summary>
        /// <param name="WithJokers"></param>
        public void AddCards(bool WithJokers)
        {
            try
            {
                int i = 1;
                int stop;

                if (WithJokers)
                {
                    stop = 55;
                }
                else
                {
                    stop = 53;
                }

                while (i != stop)
                {
                    Cards.Add(new Card(i));
                    i++;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Shuffles the deck.
        /// </summary>
        public void Shuffle()
        {
            try
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
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}