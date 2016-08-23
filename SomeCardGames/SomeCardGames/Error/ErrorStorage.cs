namespace SomeCardGames.Error
{
    /// <summary>
    /// This class is used to store error messages.
    /// </summary>
    public static class ErrorStorage
    {
        /// <summary>
        /// This message is used by the Card class, to throw an exception.
        /// </summary>
        public static string CardNotFoundException = "A caller attempted to create a card that doesn't exist.";

        /// <summary>
        /// This message is used by a lot of different card games, when a hand should not have been dealt, or created.
        /// </summary>
        public static string InvalidHandDealt = "A caller attempted to create a hand for a player or AI that is invalid.";
    }
}