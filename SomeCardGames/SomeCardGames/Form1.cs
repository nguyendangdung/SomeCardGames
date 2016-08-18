using SomeCardGames.Error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeCardGames
{
    /// <summary>
    /// The main form, that everything is displayed on.
    /// </summary>
    public partial class Form1 : Form
    {
        Main main = new Main();
        /// <summary>
        /// The inital call to this program.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is called when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            main.Startup(this);
        }

        /// <summary>
        /// Called when the play button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            main.Shutdown(0);
        }
    }
}