﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGamesAPI.API.Controls.UI;
using SomeCardGamesAPI.API.Controls.UI.Comparators;
using SomeCardGamesAPI.Error;

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
        /// <param name="TheForm"></param>
        /// <param name="controls"></param>
        /// <param name="Visibility"></param>
        public UI(object TheForm, CardBox[] controls, bool Visibility)
        {
            try
            {
                this.form = (Form)TheForm;

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
        /// Makes all of the controls in this UI visible.
        /// </summary>
        public void MakeUIVisible()
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
        public void MakeUIInvisible()
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