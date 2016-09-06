using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGames.Error;
using System.Reflection;

namespace SomeCardGames.Utility
{
    /// <summary>
    /// Holds some various random utility functions.
    /// </summary>
    public static class Util
    {
        private static Assembly _assembly = Assembly.GetExecutingAssembly();
        private static Stream _imageStream;


        /// <summary>
        /// Loads a bitmap from the resources file.
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static Bitmap LoadResource(string FileName)
        {
            try
            {
                _imageStream = _assembly.GetManifestResourceStream("SomeCardGames." + FileName);
                return new Bitmap(_imageStream);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Does some calculations for rendering purposes.
        /// </summary>
        public static Size GetScreenSize(Form1 TheForm)
        {
            try
            {
                Size a = new Size(Screen.FromControl(TheForm).WorkingArea.Width, Screen.FromControl(TheForm).WorkingArea.Height);
                return a;
            }
            catch (Exception e)
            {
                ErrorReporter.Report(e);
                return new Size();
            }
        }

        /// <summary>
        /// Returns the scale that we should use when drawing the height of objects. Returns 1 if an error occured.
        /// </summary>
        /// <param name="TheForm"></param>
        /// <returns></returns>
        public static double HeightScale(Form1 TheForm)
        {
            try
            {
                return GetScreenSize(TheForm).Height / VariableStorage.HeightProgrammedFor;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return 1;
            }
        }

        /// <summary>
        /// Returns the scale that we should use when drawing the width of objects. Returns 1 if an error occured.
        /// </summary>
        /// <param name="TheForm"></param>
        /// <returns></returns>
        public static double WidthScale(Form1 TheForm)
        {
            try
            {
                return GetScreenSize(TheForm).Width / VariableStorage.WidthProgrammedFor;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return 1;
            }
        }
    }
}