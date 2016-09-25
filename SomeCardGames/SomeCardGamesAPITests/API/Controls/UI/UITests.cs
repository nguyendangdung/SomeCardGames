using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.API.Controls.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGamesAPI.API.Controls.UI.Tests
{
    [TestClass()]
    public class UITests
    {
        [TestMethod()]
        public void UITest()
        {
            try
            {
                UI a;
                a = new UI();
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

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void DrawAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCardBoxTest()
        {
            Assert.Fail();
        }
    }
}