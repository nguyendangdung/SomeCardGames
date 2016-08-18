using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames
{
    /// <summary>
    /// This class holds some code, to reduce clutter in the Form1 class.
    /// </summary>
    public class Main
    {
        Form1 TheForm;

        /// <summary>
        /// Called by the form, to do some start up stuff.
        /// </summary>
        public void Startup(object Form)
        {
            this.CaptureTheForm(Form);
            this.GetScreenSize();
            this.SetupForm();
        }

        /// <summary>
        /// Saves the form to this class.
        /// </summary>
        /// <param name="Form"></param>
        public void CaptureTheForm(object Form)
        {
            try
            {
                TheForm = (Form1)Form;
            }
            catch (Exception e)
            {
                ErrorReporter.Report(e);
            }
        }

        /// <summary>
        /// Sets up the form.
        /// </summary>
        public void SetupForm()
        {
            TheForm.TopMost = true;
            TheForm.FormBorderStyle = FormBorderStyle.None;
            TheForm.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Gets the size of the moniter.
        /// </summary>
        public void GetScreenSize()
        {
            try
            {
                VariableStorage.ScreenWidth = Screen.FromControl(TheForm).WorkingArea.Width;
                VariableStorage.ScreenHeight = Screen.FromControl(TheForm).WorkingArea.Height;
            }
            catch(Exception e)
            {
                ErrorReporter.Report(e);
            }
        }
    }
}