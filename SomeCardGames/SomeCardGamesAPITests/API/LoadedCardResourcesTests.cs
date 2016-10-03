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
        public void GetResourceTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;

                LoadedCardResources.LoadResources870x1200();

                int i = 0;

                while (i != 54)
                {
                    if (LoadedCardResources.GetResource(i) == null)
                    {
                        Assert.Fail("Something went wrong");
                    }
                    i++;
                }

                i = 0;
                LoadedCardResources.LoadResources960x1440();

                while (i != 54)
                {
                    if (LoadedCardResources.GetResource(i) == null)
                    {
                        Assert.Fail("Something went wrong");
                    }
                    i++;
                }

                i = 0;
                LoadedCardResources.LoadResourcesHighestRes();

                while (i != 54)
                {
                    if (LoadedCardResources.GetResource(i) == null)
                    {
                        Assert.Fail("Something went wrong");
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
        public void GetBackTest()
        {
            try
            {
                Error.ErrorReporter.IsUnitTesting = true;
                LoadedCardResources.LoadResources870x1200();
                if (LoadedCardResources.GetBack() == null)
                {
                    Assert.Fail("Something is wrong");
                }
                LoadedCardResources.LoadResources960x1440();
                if (LoadedCardResources.GetBack() == null)
                {
                    Assert.Fail("Something is wrong");
                }
                LoadedCardResources.LoadResourcesHighestRes();
                if (LoadedCardResources.GetBack() == null)
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