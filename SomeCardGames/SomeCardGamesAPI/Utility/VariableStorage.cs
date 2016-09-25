using SomeCardGamesAPI.Error;
using System;
using System.Windows.Forms;

namespace SomeCardGamesAPI.Utility
{
    /// <summary>
    /// A class used to store universal variables.
    /// </summary>
    public static class VariableStorage
    {
        /// <summary>
        /// The main form.
        /// </summary>
        public static Form TheForm;

        /// <summary>
        /// If true, then this program is currently running a card game.
        /// </summary>
        public static bool IsCardGameAlreadyGoing = false;

        /// <summary>
        /// Represents how wide the screen is.
        /// </summary>
        public static int ScreenWidth = 0;

        /// <summary>
        /// Represents how tall the screen is.
        /// </summary>
        public static int ScreenHeight = 0;

        /// <summary>
        /// The height to scale all operations by when it comes to rendering.
        /// </summary>
        public static double HeightScale
        {
            get
            {
                return Util.HeightScale(TheForm);
            }
        }

        /// <summary>
        /// The width to scale all operations by when it comes to rendering.
        /// </summary>
        public static double WidthScale
        {
            get
            {
                return Util.WidthScale(TheForm);
            }
        }

        /// <summary>
        /// Represents the screen width of the monitor this game is designed for.
        /// </summary>
        public static int WidthProgrammedFor = 2560;

        /// <summary>
        /// Represents the screen height of the monitor this game is designed for.
        /// </summary>
        public static int HeightProgrammedFor = 1410;

        /// <summary>
        /// Represents how much we downscale the cards before rendering.
        /// </summary>
        public static double CardScaleFactor = .3;

        /// <summary>
        /// The width to make all cards to.
        /// </summary>
        public static int CardWidth = Convert.ToInt32(3000 * VariableStorage.CardScaleFactor);

        /// <summary>
        /// The width to make all cards to.
        /// </summary>
        public static int CardHeight = Convert.ToInt32(4200 * VariableStorage.CardScaleFactor);

        /// <summary>
        /// A way to move the form around, where it would otherwise cause an exception.
        /// </summary>
        /// <param name="Form"></param>
        public static void CollectForm(object Form)
        {
            try
            {
                TheForm = (Form)Form;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}