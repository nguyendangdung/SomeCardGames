﻿using SomeCardGamesAPI.Error;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

		/// <summary>
		/// Returns true if there is only number characters in the string.
		/// </summary>
		/// <param name="Text"></param>
		/// <returns></returns>
		public static bool IsTextOnlyNumbers(string Text)
		{
			try
			{
				foreach (char item in Text)
				{
					switch (item)
					{
						case '0':
							break;
						case '1':
							break;
						case '2':
							break;
						case '3':
							break;
						case '4':
							break;
						case '5':
							break;
						case '6':
							break;
						case '7':
							break;
						case '8':
							break;
						case '9':
							break;
						default:
							return false;
					}
				}
				return true;
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
				return false;
			}
		}

		/// <summary>
		/// Serializes an object to XML to the specified file location.
		/// </summary>
		/// <param name="FilePath">No file extensions please.</param>
		/// <param name="ToSerialize">Must contain all serializable objects.</param>
		public static void SerializeObjectToFile(string FilePath, object ToSerialize)
		{
			try
			{
				string Extension = ".xml";
				Stream stream = File.Open(new Uri(FilePath + Extension).LocalPath, FileMode.Create);
				BinaryFormatter bform = new BinaryFormatter();

				bform.Serialize(stream, ToSerialize);
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}
		}

		/// <summary>
		/// Reads an object from an binary XML document and returns it as an object.
		/// </summary>
		/// <param name="FilePath"></param>
		/// <returns></returns>
		public static object ReadSerializedObjectFromFile(string FilePath)
		{
			try
			{
				Stream stream = File.Open(new Uri(FilePath + ".xml").LocalPath, FileMode.Open);
				BinaryFormatter bform = new BinaryFormatter();
				return bform.Deserialize(stream);
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
				return null;
			}
		}

		/// <summary>
		/// Figures out if the same game already exists.
		/// </summary>
		/// <param name="GameName"></param>
		/// <param name="PathToSaveDirectory"></param>
		/// <returns></returns>
		public static bool DoesGameAlreadyExist(string GameName, string PathToSaveDirectory)
		{
			try
			{
				List<string> a = new List<string>(Directory.GetFiles(PathToSaveDirectory));
				return a.Contains(GameName);
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
				return false;
			}
		}
    }
}