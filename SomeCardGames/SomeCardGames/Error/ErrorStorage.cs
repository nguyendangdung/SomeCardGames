using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Error
{
    /// <summary>
    /// This class is used to store error messages.
    /// </summary>
    public static class ErrorStorage
    {
        public static string CardNotFoundException = "A caller attempted to create a card that doesn't exist";
    }
}