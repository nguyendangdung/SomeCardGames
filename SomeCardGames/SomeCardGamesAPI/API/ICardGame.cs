using System.Configuration;
using System.Drawing;
using System.Runtime.Serialization;

namespace SomeCardGamesAPI.API
{
    /// <summary>
    /// Things that implement this interface are card games
    /// </summary>
    public interface ICardGame : ISerializable
    {
        /// <summary>
        /// Called by the main form when the new, load, or exit button is clicked, and this card game was running previously.
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
        void Load(string GameName);

        /// <summary>
        /// This is called when the user wants to load the options of a game of whatever card game is inheriting from this.
        /// </summary>
        void Options();

        /// <summary>
        /// This is called when the user wants to save a game of whatever card game is inheriting from this.
        /// </summary>
        void Save();

        /// <summary>
        /// This is called when the user wants to load a new game of whatever card game is inheriting from this.
        /// </summary>
        void New();
    }
}