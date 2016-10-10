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

        /// <summary>
        /// Sets the settings file embedded in here with new game settings, for the next game.
        /// Returns true if it completed successfully.
        /// </summary>
        public void RefreshGameOptions()
        {

        }
    }
}