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
        public static string CardNotFoundException = "A caller attempted to create a card that doesn't exist";
    }
}