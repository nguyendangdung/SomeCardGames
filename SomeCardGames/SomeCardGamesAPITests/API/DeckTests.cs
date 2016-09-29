﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCardsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ShuffleTest()
        {
            Assert.Fail();
        }
    }
}