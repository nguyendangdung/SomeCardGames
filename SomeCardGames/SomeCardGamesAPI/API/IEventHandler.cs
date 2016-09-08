using System.Windows.Forms;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// The interface for all card game event handlers.
    /// </summary>
    public interface IEventHandler
    {
        /// <summary>
        /// This is called when a card is clicked on.
        /// </summary>
        void CardWasClickedOn(Card card, MouseEventArgs e);
    }
}