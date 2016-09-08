using System;
using System.Drawing;
using System.Windows.Forms;

using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Utility;
using SomeCardGamesAPI.Error;

namespace SomeCardGames
{
    /// <summary>
    /// This class holds some code, to reduce clutter in the Form1 class.
    /// </summary>
    public class Main
    {
        /// <summary>
        /// Represents the current card game logic that is running.
        /// </summary>
        public ICardGame Current;

        /// <summary>
        /// Called by the form, to do some start up stuff.
        /// </summary>
        public void Startup(object Form)
        {
            try
            {
                VariableStorage.CollectForm(Form);
                LoadedCardResources.LoadResources();
                this.SetupForm();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                try
                {
                    throw new Exception("Test", TheException);
                }
                catch (Exception LeException)
                {
                    ErrorReporter.Report(LeException);
                }
            }
        }

        /// <summary>
        /// Called when we want to shut this program down.
        /// </summary>
        public void Shutdown(int Code)
        {
            try
            {
                Environment.Exit(Code);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Sets up the form.
        /// </summary>
        private void SetupForm()
        {
            try
            {
                VariableStorage.TheForm.TopMost = true;
                VariableStorage.TheForm.FormBorderStyle = FormBorderStyle.Fixed3D;
                VariableStorage.TheForm.WindowState = FormWindowState.Normal;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Used to stop the old card game, and start the new one.
        /// </summary>
        /// <param name="game"></param>
        public void StartNewCardGame(ICardGame game)
        {
            try
            {
                if (VariableStorage.IsCardGameAlreadyGoing)
                {
                    this.Current.Stop();
                }

                VariableStorage.IsCardGameAlreadyGoing = true;

                this.Current = game;
                game.Start();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}