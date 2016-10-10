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
                this.Size = VariableStorage.TheForm.Size;
                this.Location = VariableStorage.TheForm.Location;
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}