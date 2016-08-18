using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Error;

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
            catch (InvalidCastException InvalidCast)
            {
                ErrorReporter.Report(InvalidCast);
            }
        }
    }
}