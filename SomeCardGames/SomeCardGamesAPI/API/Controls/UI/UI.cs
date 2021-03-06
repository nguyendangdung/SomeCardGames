﻿using SomeCardGamesAPI.API.Controls.UI.Comparators;
using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SomeCardGamesAPI.API.Controls.UI
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
        public List<CardBox> Controls;

        /// <summary>
        /// Used to order objects into the Controls list properly.
        /// </summary>
        public CardBoxComparator Comparator = new CardBoxComparator();

        private bool AreWeVisible = true;

        /// <summary>
        /// Tells us if this UI is visible or not.
        /// </summary>
        public bool Visible
        {
            get
            {
                return AreWeVisible;
            }
            set
            {
                this.AreWeVisible = value;

                if (value)
                {
                    this.MakeUIVisible();
                }
                else
                {
                    this.MakeUIInvisible();
                }
            }
        }

        /// <summary>
        /// The constructor for the UI class.
        /// </summary>
        public UI()
        {
        }

        /// <summary>
        /// The constructor for the UI class.
        /// </summary>
        /// <param name="TheForm"></param>
        /// <param name="controls"></param>
        /// <param name="Visibility"></param>
        public void ConstructMe(object TheForm, CardBox[] controls, bool Visibility)
        {
            try
            {
                this.Controls = new List<CardBox>();
                this.form = (Form)TheForm;
                this.form.Click += Form_Click;

                foreach (CardBox item in controls)
                {
                    this.AddCardBox(item);
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called by the form whenever there is a click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Click(object sender, EventArgs e)
        {
            try
            {
                Point Location = new Point(Cursor.Position.X, Cursor.Position.Y);

                foreach (CardBox item in this.Controls)
                {
                    if (item.WasIClicked(Location))
                    {
                        item.OnClick(Location);
                        break;
                    }
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// This should be called after we intercept a draw event. This attempts to draw all controls in this UI.
        /// </summary>
        /// <param name="g"></param>
        public void DrawAll(Graphics g)
        {
            try
            {
                foreach (CardBox item in this.Controls)
                {
                    if (item.Visible)
                    {
                        item.Draw(g);
                    }
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Makes all of the controls in this UI visible.
        /// </summary>
        private void MakeUIVisible()
        {
            try
            {
                this.AreWeVisible = true;

                foreach (CardBox item in this.Controls)
                {
                    item.Visible = true;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Makes all of the controls in this UI invisible.
        /// </summary>
        private void MakeUIInvisible()
        {
            try
            {
                this.AreWeVisible = false;

                foreach (CardBox item in this.Controls)
                {
                    item.Visible = false;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Adds said control into the controls list.
        /// </summary>
        /// <param name="control"></param>
        public void AddCardBox(CardBox control)
        {
            try
            {
                //Supposedly, this should insert objects into the correct order.
                int index = this.Controls.BinarySearch(control, this.Comparator);
                if (index < 0) index = ~index;
                this.Controls.Insert(index, control);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}