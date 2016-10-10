using System;
using System.Windows.Forms;

using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;

namespace Golf.Code.UI_s.WinForms
{
    /// <summary>
    /// This form is called when creating a new golf game.
    /// </summary>
    public class NewGolfForm : Form
    {
        /// <summary>
        /// The constructor for the NewGolfForm class.
        /// </summary>
        public NewGolfForm()
        {
            try
            {
                VariableStorage.TheForm.AddOwnedForm(this);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}