﻿using Golf.Code;
using SomeCardGamesAPI.Error;
using System;
using System.Windows.Forms;

namespace SomeCardGames
{
    /// <summary>
    /// The main form, that everything is displayed on.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        ///Kicks off various functions.
        /// </summary>
        private Main main = new Main();

        /// <summary>
        /// The initial call to this program.
        /// </summary>
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// This is called when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                main.Startup();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// This is called when the form needs to redraw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (main.Current != null)
                {
                    main.Current.Draw(e.Graphics);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called whenever the form is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void golfToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                this.main.StartNewCardGame(new GolfLogic());
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void loadToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                this.main.StopCardGame();
                this.main.Shutdown(0);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void golfToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void golfToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void golfToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void universalOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void newToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void newToolStripMenuItem6_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.main.StopCardGame();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void loadToolStripMenuItem5_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.main.StopCardGame();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        private void saveToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.main.Current.Save();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}