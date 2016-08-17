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
            main.CaptureTheForm(1);
        }
    }
}
