using System.Configuration;
using System.Drawing;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// Things that implement this interface are card games
    /// </summary>
    public interface ICardGame
    {
        /// <summary>
        /// Called by the main form when the new card game button is clicked, and a card game is selected.
        /// </summary>
        void Start();

        /// <summary>
        /// Called by the main form when the new card game button is clicked, and this card game was running previously.
        /// </summary>
        void Stop();

        /// <summary>
        /// Passes a call on to the card games drawer.
        /// </summary>
        /// <param name="G"></param>
        void Draw(Graphics G);

        /// <summary>
        /// Returns the settings file for the current card game.
        /// </summary>
        /// <returns></returns>
        SettingsBase GetSettings();

        /// <summary>
        /// This is called when the user wants to load a game of whatever card game is inheriting from this.
        /// </summary>
        void LaunchLoadMenu();

        /// <summary>
        /// This is called when the user wants to load the options of a game of whatever card game is inheriting from this.
        /// </summary>
        void LaunchOptions();

        /// <summary>
        /// This is called when the user wants to save a game of whatever card game is inheriting from this.
        /// </summary>
        void LaunchSaveMenu();

        /// <summary>
        /// This is called when the user wants to load a new game of whatever card game is inheriting from this.
        /// </summary>
        void LaunchNewMenu();
    }
}