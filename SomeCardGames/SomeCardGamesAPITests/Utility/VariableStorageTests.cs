﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace SomeCardGamesAPI.Utility.Tests
{
    [TestClass()]
    public class VariableStorageTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CollectFormTest()
        {
            Error.ErrorReporter.IsUnitTesting = true;

            //Tests the normal form branch
            Form a = new Form();
            a.Name = "Test Form";
            VariableStorage.CollectForm(a);
            Assert.AreEqual(VariableStorage.TheForm, a);
            //

            //Tests if the form was null, how we handle it
            VariableStorage.CollectForm(null);
            //
        }
    }
}