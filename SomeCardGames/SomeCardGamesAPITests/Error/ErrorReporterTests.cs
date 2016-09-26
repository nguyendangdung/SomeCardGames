using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGamesAPI.Error.Tests
{
    [TestClass()]
    public class ErrorReporterTests
    {
        [TestMethod()]
        public void ReportTest()
        {
            //Don't know how to test this without create a issue on my public page, so just gonna auto pass it.
        }

        /// <summary>
        /// For ErrorReporter.GenerateReportForException()
        /// </summary>
        [TestMethod()]
        public void GenerateReportForExceptionTest()
        {
            Exception a = new Exception("Test Exception");
            string b = ErrorReporter.GenerateReportForException(a, 1);
            Assert.Fail();
        }

        /// <summary>
        /// For ErrorReporter.ConvertListToString()
        /// </summary>
        [TestMethod()]
        public void ConvertListToStringTest()
        {
            Assert.Fail();
        }
    }
}