using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SomeCardGamesAPI.API.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void GetSizeTest()
        {
            try
            {
                int i = 1;

                while (i != 10)
                {
                    Deck a = new Deck(false, i);

                    if (a.GetSize() != i * 52)
                    {
                        Assert.Fail("Deck size was incorrect");
                        return;
                    }
                    i++;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void GetTopTest()
        {
            try
            {
                Deck a = new Deck(true, 2);
                int Card = a.Cards[0].WhatCard;

                if (a.GetTop().WhatCard != Card)
                {
                    Assert.Fail("Top card method is broken.");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void AddCardsTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                Deck a = new Deck(true, 1);
                a.AddCards(true);

                Card b = new Card(1);
                int i = 1;
                int NumberOfCurrentCard = 0;

                while (i != 55)
                {
                    int ii = 0;

                    while (ii != a.GetSize())
                    {
                        if (a.Cards[ii].WhatCard == b.WhatCard)
                        {
                            NumberOfCurrentCard++;
                        }
                        ii++;
                    }
                    if (NumberOfCurrentCard != 2)
                    {
                        Assert.Fail("Not all of the cards were properly added");
                    }
                    else
                    {
                        NumberOfCurrentCard = 0;
                    }

                    b.WhatCard = i;
                    i++;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void ShuffleTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;

                Deck a = new Deck(true, 1);

                Deck b = new Deck(true, 1);
                b.Cards = new List<Card>(a.Cards);

                b.Shuffle();

                if (this.Are2ListsTheSame(a.Cards, b.Cards))
                {
                    Assert.Fail("The shuffle failed to work properly.");
                }


                //Assert.AreNotEqual(b.Cards, a.Cards);
            }
            catch (Exception e)
            {
                int i = 0;
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// An exception will occur if the lists are not the exact same size.
        /// </summary>
        /// <param name="One"></param>
        /// <param name="Two"></param>
        /// <returns></returns>
        private bool Are2ListsTheSame(List<Card> One, List<Card> Two)
        {
            try
            {
                if (One.Count != Two.Count)
                {
                    Assert.Fail("The lists do not have identical sizes");
                }

                int i = 0;

                foreach (Card item in One)
                {
                    if (Two[i] != item)
                    {
                        return false;
                    }
                    i++;
                }

                return true;
            }
            catch (Exception e)
            {
                Assert.Fail("There is an error in the test code");
                return true;
            }
        }
    }
}