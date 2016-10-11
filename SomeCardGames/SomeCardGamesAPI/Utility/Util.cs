using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;
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
        /// Returns the scale that we should use when drawing the width of objects. Returns 1 if an error occurred.
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

        /// <summary>
        /// Parses a null ended string into a list, assuming the string is something like an entire file in one line or something.
        /// </summary>
        /// <returns></returns>
        public static List<string> ParseString(string Parse)
        {
            try
            {
                List<string> Ret = new List<string>();

                string[] EscapeSequences = { "\r\n", "\n", "\r", };

                foreach (string item in Parse.Split(EscapeSequences, StringSplitOptions.RemoveEmptyEntries))
                {
                    Ret.Add(item);
                }

                return Ret;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Returns a new version of the previously passed in list, that has been randomized.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> Randomize<T>(List<T> list)
        {
            try
            {
                List<T> randomizedList = new List<T>();
                Random rnd = new Random(1999);
                while (list.Count > 0)
                {
                    int index = rnd.Next(0, list.Count); //pick a random item from the master list
                    randomizedList.Add(list[index]); //place it at the end of the randomized list
                    list.RemoveAt(index);
                }
                return randomizedList;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }
    }
}