using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Error
{
    public static class ErrorStorage
    {
        public static void ThrowCardNotFoundException()
        {
            throw new Exception("Card not found");
        }
    }
}