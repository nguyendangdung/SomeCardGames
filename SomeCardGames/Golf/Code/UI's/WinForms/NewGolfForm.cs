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
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void NewGolfForm_Load(object sender, EventArgs e)
        {
			try
			{
				this.AICountTBox.Text = Golf.Properties.Settings.Default.GolfAIPlayers.ToString();
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void AICountTBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (!Util.IsTextOnlyNumbers(this.AICountTBox.Text))
				{
					MessageBox.Show("Error:", "There was a non number character found in the AI box.");
					this.AICountTBox.Text = "3";
				}
				else
				{
					if (this.AICountTBox.Text.Trim(' ') != "")
					{
						Golf.Properties.Settings.Default.GolfAIPlayers = Convert.ToInt32(this.AICountTBox.Text);
					}
				}
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}
		}
	}
}