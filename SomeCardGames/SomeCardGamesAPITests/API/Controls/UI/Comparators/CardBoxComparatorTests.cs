using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SomeCardGamesAPI.API.Controls.UI.Comparators.Tests
{
    [TestClass()]
    public class CardBoxComparatorTests
    {
        [TestMethod()]
        public void CompareTest()
        {
            try
            {
                CardBox a = new CardBox();
                a.DrawOrder = 1;
                CardBox b = new CardBox();
                b.DrawOrder = 2;
                CardBoxComparator c;
                c = new CardBoxComparator();
                if (c.Compare(a, b) > 1)
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