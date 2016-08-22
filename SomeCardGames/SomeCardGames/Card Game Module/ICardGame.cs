namespace SomeCardGames.Card_Game_Module
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
    }
}