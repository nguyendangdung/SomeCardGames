using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGamesAPI.Error;
using System.Collections;

namespace SomeCardGamesAPI.API.Controls
{
    /// <summary>
    /// A class that creates the basis of a UI concept.
    /// </summary>
    public class UI
    {
        /// <summary>
        /// The form the controls we have use.
        /// </summary>
        public Form form;

        /// <summary>
        /// All of the card boxes that we have here.
        /// </summary>
        List<CardBox> Controls;

        /// <summary>
        /// The constructor for the UI class.
        /// </summary>
        /// <param name="TheForm"></param>
        /// <param name="controls"></param>
        /// <param name="Visibility"></param>
        public UI(object TheForm, CardBox[] controls, bool Visibility)
        {
            try
            {
                this.form = (Form)TheForm;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        public void AddCardBox(CardBox control)
        {

        }


    }
}