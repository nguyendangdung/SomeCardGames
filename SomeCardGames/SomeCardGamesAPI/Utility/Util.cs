using SomeCardGamesAPI.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SomeCardGamesAPI.Utility
{
    /// <summary>
    /// Holds some various random utility functions.
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// Does some calculations for rendering purposes.
        /// </summary>
        public static Size GetScreenSize(Form TheForm)
        {
            try
            {
                Size a = new Size(Screen.FromControl(TheForm).WorkingArea.Width, Screen.FromControl(TheForm).WorkingArea.Height);
                
                return a;
            }
            catch (Exception e)
            {
                //Oops
                return new Size();
            }
        }

        /// <summary>
        /// Returns the scale that we should use when drawing the height of objects. Returns 1 if an error occurred.
        /// </summary>
        /// <param name="TheForm"></param>
        /// <returns></returns>
        public static double HeightScale(Form TheForm)
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
        public static double WidthScale(Form TheForm)
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