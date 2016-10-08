using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SomeCardGamesAPI.API.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void CardTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                Card a = new Card(19);
                if (a.IsFaceUp != false)
                {
                    Assert.Fail();
                }
                if (a.WhatCard != 19)
                {
                    Assert.Fail();
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}