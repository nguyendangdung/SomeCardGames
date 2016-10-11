using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;
using System;
using System.Windows.Forms;

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
        public void Startup()
        {
            try
            {
                LoadedCardResources.LoadResources();
                this.SetupForm();
                VariableStorage.TheForm.Text = VariableStorage.GetRandomTitle();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
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
                game.New();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called by several buttons, when the current card game needs to be stopped.
        /// </summary>
        public void StopCardGame()
        {
            try
            {
                if (VariableStorage.IsCardGameAlreadyGoing)
                {
                    this.Current.Save();
                    this.Current.Stop();
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}