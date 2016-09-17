using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Size GetMiddleStackSize
        {
            get
            {
                return new Size(0, 0);
            }
        }

        public Point GetTopLeft
        {
            get
            {
                return new Point(0, 0);
            }
        }

        public CardBox MiddleStack = new CardBox(CreateMiddleStack());

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

                controls[0] = MiddleStack;

                this.ConstructMe(VariableStorage.TheForm, controls, Visibility);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        public static CardBox CreateMiddleStack()
        {
            return new CardBox(LoadedCardResources.GetBack(), GetMiddleStackSize, GetTopLeft, VariableStorage.TheForm);
        }

        public static void
    }
}
