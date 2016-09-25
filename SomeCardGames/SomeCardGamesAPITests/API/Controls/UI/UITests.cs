using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.API.Controls.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //Normal Path
                UI a;
                a = new UI();
                //
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void ConstructMeNormalTest()
        {
            try
            {
                Form a = this.GenerateForm(true);
                CardBox b = new CardBox()
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// If normal = true, we generate a non null form. Otherwise, the form is null;
        /// </summary>
        /// <param name="Normal"></param>
        private Form GenerateForm(bool Normal)
        {
            try
            {
                if (Normal)
                {
                    Form a;

                    a = new Form();
                    a.Text = "Test Title";

                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return null;
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