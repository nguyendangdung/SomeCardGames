using SomeCardGamesAPI.Error;
using System;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// Used to represent a card in the game.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Used to tell if the card is face up or face down graphically.
        /// </summary>
        public bool IsFaceUp = false;

        /// <summary>
        /// Used to tell what card this card is.
        /// </summary>
        public int WhatCard;
        /// <summary>
        /// The constructor for the Card class.
        /// </summary>
        /// <param name="TheCard"></param>
        public Card(int TheCard)
        {
            try
            {
                if (TheCard > 53 | TheCard < 1)
                {
                    throw new Exception(ErrorStorage.CardNotFoundException);
                }
                else
                {
                    this.WhatCard = TheCard;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Used to compare all of the different cards in a deck of cards.
        /// </summary>
        public enum Cards
        {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
            TwoSpades, ThreeSpades, FourSpades, FiveSpades, SixSpades, SevenSpades, EightSpades, NineSpades, TenSpades, JackSpades, QueenSpades, KingSpades, AceSpades,
            TwoClubs, ThreeClubs, FourClubs, FiveClubs, SixClubs, SevenClubs, EightClubs, NineClubs, TenClubs, JackClubs, QueenClubs, KingClubs, AceClubs,
            TwoHearts, ThreeHearts, FourHearts, FiveHearts, SixHearts, SevenHearts, EightHearts, NineHearts, TenHearts, JackHearts, QueenHearts, KingHearts, AceHearts,
            TwoDiamonds, ThreeDiamonds, FourDiamonds, FiveDiamonds, SixDiamonds, SevenDiamonds, EightDiamonds, NineDiamonds, TenDiamonds, JackDiamonds, QueenDiamonds, KingDiamonds, AceDiamonds,
            RedJoker, BlackJoker
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        }
    }
}