using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;

namespace Golf.Code.UI_s.WinForms
{
    public partial class NewGolfForm : Form
    {
        /// <summary>
        /// The constructor for the NewGolfForm class.
        /// </summary>
        public NewGolfForm()
        {
            try
            {
                InitializeComponent();
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

        private void NewGolfForm_Load(object sender, EventArgs e)
        {

        }
    }
}