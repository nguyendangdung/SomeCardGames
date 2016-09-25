using Golf.Code.UI_s.Main.Controls;
using SomeCardGamesAPI.API.Controls;
using SomeCardGamesAPI.API.Controls.UI;
using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;
using System;

namespace Golf.Code.UI_s.Main
{
    /// <summary>
    /// This UI is shown whenever the player is playing a golf game.
    /// </summary>
    public class MainUI : UI
    {
        /// <summary>
        /// Represents the stack of cards in the middle of the table.
        /// </summary>
        public CardBox MiddleStack;

        /// <summary>
        /// The constructor for the MainUI class.
        /// </summary>
        /// <param name="Visibility"></param>
        /// <param name="GolfGame"></param>
        public MainUI(bool Visibility, GolfLogic GolfGame)
        {
            try
            {
                CardBox[] controls = new CardBox[1];
                MiddleStack = new CardBox(new MiddleStack(GolfGame));

                controls[0] = MiddleStack;

                this.ConstructMe(VariableStorage.TheForm, controls, Visibility);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}