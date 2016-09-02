namespace SomeCardGames.Utility
{
    /// <summary>
    /// A class used to store universal variables.
    /// </summary>
    public static class VariableStorage
    {
        /// <summary>
        /// The main form.
        /// </summary>
        public static Form1 TheForm;

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
        /// Represents the screen width of the moniter this game is designed for.
        /// </summary>
        public static int WidthProgrammedFor = 2560;

        /// <summary>
        /// Represents the screen height of the moniter this game is designed for.
        /// </summary>
        public static int HeightProgrammedFor = 1410;
    }
}