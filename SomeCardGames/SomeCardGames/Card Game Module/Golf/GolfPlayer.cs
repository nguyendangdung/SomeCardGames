﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Base;
using SomeCardGames.Error;

namespace SomeCardGames.Card_Game_Module.Golf
{
    /// <summary>
    /// Holds the logic for AI, and the collections to store a human players cards.
    /// </summary>
    public class GolfPlayer
    {
        /// <summary>
        /// If this is true, then the player is a human, and does not need AI logic running.
        /// </summary>
        public bool IsHuman;

        /// <summary>
        /// Represents the hand of the current "player".
        /// </summary>
        public Card[] Hand;

        /// <summary>
        /// The constructor for the GolfPlayer class.
        /// </summary>
        /// <param name="cards">The hand dealt to the player</param>
        /// <param name="IsAHuman"></param>
        public GolfPlayer(Card[] cards, bool IsAHuman)
        {
            try
            {
                IsHuman = IsAHuman;
                Hand = new Card[6];

                if (cards.Length == 6)
                {
                    Hand = cards;
                }
                else
                {
                    throw new Exception(ErrorStorage.InvalidHandDealt);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}