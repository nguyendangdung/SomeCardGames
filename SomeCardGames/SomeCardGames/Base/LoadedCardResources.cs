using SomeCardGames.Error;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SomeCardGames.Base
{//Job for next time: split the base stuff we need into a dll, so i can split the Golf code into a dll.
    /// <summary>
    /// This class is used to store bitmaps for cards.
    /// </summary>
    public static class LoadedCardResources
    {
        private static List<Bitmap> CardResources = new List<Bitmap>();

        private static Bitmap Back;

        /// <summary>
        /// Loads a bunch of resources into memory.
        /// </summary>
        /// <param name="Card"></param>
        /// <returns></returns>
        public static Bitmap GetResource(int Card)
        {
            try
            {
                return CardResources.ElementAt(Card);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Gets what the back of the cards looks like.
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetBack()
        {
            try
            {
                return Back;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Kicks off the necessary steps to load all resources needed.
        /// </summary>
        public static void LoadResources()
        {
            try
            {
                Back = MainResources.MainResources.back;
                CardResources.Add(MainResources.MainResources._1);
                CardResources.Add(MainResources.MainResources._2);
                CardResources.Add(MainResources.MainResources._3);
                CardResources.Add(MainResources.MainResources._4);
                CardResources.Add(MainResources.MainResources._5);
                CardResources.Add(MainResources.MainResources._6);
                CardResources.Add(MainResources.MainResources._7);
                CardResources.Add(MainResources.MainResources._8);
                CardResources.Add(MainResources.MainResources._9);
                CardResources.Add(MainResources.MainResources._10);
                CardResources.Add(MainResources.MainResources._11);
                CardResources.Add(MainResources.MainResources._12);
                CardResources.Add(MainResources.MainResources._13);
                CardResources.Add(MainResources.MainResources._14);
                CardResources.Add(MainResources.MainResources._15);
                CardResources.Add(MainResources.MainResources._16);
                CardResources.Add(MainResources.MainResources._17);
                CardResources.Add(MainResources.MainResources._18);
                CardResources.Add(MainResources.MainResources._19);
                CardResources.Add(MainResources.MainResources._20);
                CardResources.Add(MainResources.MainResources._21);
                CardResources.Add(MainResources.MainResources._22);
                CardResources.Add(MainResources.MainResources._23);
                CardResources.Add(MainResources.MainResources._24);
                CardResources.Add(MainResources.MainResources._25);
                CardResources.Add(MainResources.MainResources._26);
                CardResources.Add(MainResources.MainResources._27);
                CardResources.Add(MainResources.MainResources._28);
                CardResources.Add(MainResources.MainResources._29);
                CardResources.Add(MainResources.MainResources._30);
                CardResources.Add(MainResources.MainResources._31);
                CardResources.Add(MainResources.MainResources._32);
                CardResources.Add(MainResources.MainResources._33);
                CardResources.Add(MainResources.MainResources._34);
                CardResources.Add(MainResources.MainResources._35);
                CardResources.Add(MainResources.MainResources._36);
                CardResources.Add(MainResources.MainResources._37);
                CardResources.Add(MainResources.MainResources._38);
                CardResources.Add(MainResources.MainResources._39);
                CardResources.Add(MainResources.MainResources._40);
                CardResources.Add(MainResources.MainResources._41);
                CardResources.Add(MainResources.MainResources._42);
                CardResources.Add(MainResources.MainResources._43);
                CardResources.Add(MainResources.MainResources._44);
                CardResources.Add(MainResources.MainResources._45);
                CardResources.Add(MainResources.MainResources._46);
                CardResources.Add(MainResources.MainResources._47);
                CardResources.Add(MainResources.MainResources._48);
                CardResources.Add(MainResources.MainResources._49);
                CardResources.Add(MainResources.MainResources._50);
                CardResources.Add(MainResources.MainResources._51);
                CardResources.Add(MainResources.MainResources._52);
                CardResources.Add(MainResources.MainResources._53);
                CardResources.Add(MainResources.MainResources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}