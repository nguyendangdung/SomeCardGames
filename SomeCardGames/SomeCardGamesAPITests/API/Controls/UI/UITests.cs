using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeCardGamesAPI.Error;
using System;
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
                ErrorReporter.IsUnitTesting = true;
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
        public void ConstructMeTest()
        {
            try
            {
                ErrorReporter.IsUnitTesting = true;
                Form a = this.GenerateForm(true);
                CardBox b = new CardBox(SomeCardGamesAPITests.TestResources.TriangleGrid, new System.Drawing.Size(10, 10), new System.Drawing.Point(10, 10));
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
                ErrorReporter.IsUnitTesting = true;
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
        public void AddCardBoxTest()
        {
            try
            {
                ErrorReporter.IsUnitTesting = true;

                UI a = new UI();

                CardBox[] controls = new CardBox[1];
                CardBox card = new CardBox(SomeCardGamesAPITests.TestResources.TriangleGrid, new System.Drawing.Size(10, 10), new System.Drawing.Point(100, 100));

                controls[0] = card;

                a.ConstructMe((object)new Form(), controls, true);

                if (a == null | a.Controls[0] != card)
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