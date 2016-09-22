using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Golf.Code.UI_s.Main.Controls;

using SomeCardGamesAPI.API;
using SomeCardGamesAPI.API.Controls;
using SomeCardGamesAPI.API.Controls.UI;
using SomeCardGamesAPI.Utility;
using SomeCardGamesAPI.Error;

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