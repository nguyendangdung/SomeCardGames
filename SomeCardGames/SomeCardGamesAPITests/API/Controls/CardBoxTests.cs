using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.API.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGamesAPI.API.Controls.Tests
{
    [TestClass()]
    public class CardBoxTests
    {
        [TestMethod()]
        public void CardBoxTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;

                CardBox a = new CardBox();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        
        [TestMethod()]
        public void CardBoxTest1()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;

                CardBox a = new CardBox(SomeCardGamesAPITests.TestResources.TriangleGrid, new System.Drawing.Size(100, 100), new System.Drawing.Point(10, 10));
                CardBox b = new CardBox(a);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void CardBoxTest2()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;

                CardBox a = new CardBox(SomeCardGamesAPITests.TestResources.TriangleGrid, new System.Drawing.Size(100, 100), new System.Drawing.Point(10, 10));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void ConstructMeTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                CardBox a = new CardBox();
                a.ConstructMe(SomeCardGamesAPITests.TestResources.TriangleGrid, new System.Drawing.Size(100, 100), new System.Drawing.Point(10, 10));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void DrawTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void WasIClickedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OnClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PreDrawTest()
        {
            Assert.Fail();
        }
    }
}