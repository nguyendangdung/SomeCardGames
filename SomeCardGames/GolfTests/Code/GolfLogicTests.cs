using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Golf.Code.Tests
{
    [TestClass()]
    public class GolfLogicTests
    {
        [TestMethod()]
        public void GolfLogicTest()
        {
            try
            {
                SomeCardGamesAPI.Error.ErrorReporter.IsUnitTesting = true;
                GolfLogic a;
                a = new GolfLogic();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void StartTest()
        {
            try
            {
                SomeCardGamesAPI.Error.ErrorReporter.IsUnitTesting = true;
                SomeCardGamesAPI.Utility.VariableStorage.TheForm = new System.Windows.Forms.Form();
                GolfLogic a;
                a = new GolfLogic();
                a.Start();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void StopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSettingsTest()
        {
            Assert.Fail();
        }
    }
}