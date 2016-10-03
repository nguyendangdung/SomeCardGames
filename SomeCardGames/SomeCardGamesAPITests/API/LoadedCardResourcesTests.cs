using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGamesAPI.API.Tests
{
    [TestClass()]
    public class LoadedCardResourcesTests
    {
        [TestMethod()]
        public void LoadResourcesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetResourceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBackTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoadResources870x1200Test()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                LoadedCardResources.LoadResources870x1200();
                if (LoadedCardResources.GetResource(20) == null)
                {
                    Assert.Fail("Something is wrong");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void LoadResources960x1440Test()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                LoadedCardResources.LoadResources960x1440();
                if (LoadedCardResources.GetResource(20) == null)
                {
                    Assert.Fail("Something is wrong");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void LoadResourcesTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoadResourcesHighestResTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                LoadedCardResources.LoadResourcesHighestRes();
                if (LoadedCardResources.GetResource(20) == null)
                {
                    Assert.Fail("Something is wrong");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}