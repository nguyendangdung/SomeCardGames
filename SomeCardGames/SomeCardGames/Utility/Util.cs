using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Utility
{
    /// <summary>
    /// Holds some various random utility functions.
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// Loads a bitmap from the resources file.
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static Bitmap LoadResource(string FileName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(FileName);
        }
    }
}
