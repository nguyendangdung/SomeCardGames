using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Golf.Code.UI_s.Controls;

using SomeCardGamesAPI.API;
using SomeCardGamesAPI.API.Controls;
using SomeCardGamesAPI.API.Controls.UI;
using SomeCardGamesAPI.Utility;
using SomeCardGamesAPI.Error;

namespace Golf.Code.UIs
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
        /// <param name="TheForm"></param>
        /// <param name="controls"></param>
        /// <param name="Visibility"></param>
        public MainUI(bool Visibility)
        {
            try
            {
                CardBox[] controls = new CardBox[1];
                MiddleStack = new CardBox(this.CreateMiddleStack());

                controls[0] = MiddleStack;

                this.ConstructMe(VariableStorage.TheForm, controls, Visibility);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Creates the CardBox for the middle stack of cards.
        /// </summary>
        /// <returns></returns>
        private CardBox CreateMiddleStack()
        {
            try
            {
                return new MiddleStack();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }
    }
}
