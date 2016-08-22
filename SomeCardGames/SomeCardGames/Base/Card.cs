﻿using SomeCardGames.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This namespace is used to store various things that every card game uses.
/// </summary>
namespace SomeCardGames.Base
{
    /// <summary>
    /// Used to represent a card in the game.
    /// </summary>
    public class Card
    {

        /// <summary>
        /// The constructor for the Card class.
        /// </summary>
        /// <param name="TheCard"></param>
        public Card(int TheCard)
        {
            try
            {
                if (TheCard > 51 | TheCard < 1)
                {

                }
                this.WhatCard = TheCard;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Used to tell what card this card is.
        /// </summary>
        int WhatCard;


        /// <summary>
        /// Used to compare all of the different cards in a deck of cards.
        /// </summary>
        public enum Cards
        {
            TwoSpades, ThreeSpades, FourSpades, FiveSpades, SixSpades, SevenSpades, EightSpades, NineSpades, TenSpades, JackSpades, QueenSpades, KingSpades, AceSpades,
            TwoClubs, ThreeClubs, FourClubs, FiveClubs, SixClubs, SevenClubs, EightClubs, NineClubs, TenClubs, JackClubs, QueenClubs, KingClubs, AceClubs,
            TwoHearts, ThreeHearts, FourHearts, FiveHearts, SixHearts, SevenHearts, EightHearts, NineHearts, TenHearts, JackHearts, QueenHearts, KingHearts, AceHearts,
            TwoDiamonds, ThreeDiamonds, FourDiamonds, FiveDiamonds, SixDiamonds, SevenDiamonds, EightDiamonds, NineDiamonds, TenDiamonds, JackDiamonds, QueenDiamonds, KingDiamonds, AceDiamonds
        }
    }
}
