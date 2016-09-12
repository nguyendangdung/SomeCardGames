using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SomeCardGamesAPI.API
{
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
        /// Loads resources for the resolution of 870x1200.
        /// </summary>
        public static void LoadResources870x1200()
        {
            try
            {
                Back = MainResources870x1200.Resources.back;
                CardResources.Add(MainResources870x1200.Resources._1);
                CardResources.Add(MainResources870x1200.Resources._2);
                CardResources.Add(MainResources870x1200.Resources._3);
                CardResources.Add(MainResources870x1200.Resources._4);
                CardResources.Add(MainResources870x1200.Resources._5);
                CardResources.Add(MainResources870x1200.Resources._6);
                CardResources.Add(MainResources870x1200.Resources._7);
                CardResources.Add(MainResources870x1200.Resources._8);
                CardResources.Add(MainResources870x1200.Resources._9);
                CardResources.Add(MainResources870x1200.Resources._10);
                CardResources.Add(MainResources870x1200.Resources._11);
                CardResources.Add(MainResources870x1200.Resources._12);
                CardResources.Add(MainResources870x1200.Resources._13);
                CardResources.Add(MainResources870x1200.Resources._14);
                CardResources.Add(MainResources870x1200.Resources._15);
                CardResources.Add(MainResources870x1200.Resources._16);
                CardResources.Add(MainResources870x1200.Resources._17);
                CardResources.Add(MainResources870x1200.Resources._18);
                CardResources.Add(MainResources870x1200.Resources._19);
                CardResources.Add(MainResources870x1200.Resources._20);
                CardResources.Add(MainResources870x1200.Resources._21);
                CardResources.Add(MainResources870x1200.Resources._22);
                CardResources.Add(MainResources870x1200.Resources._23);
                CardResources.Add(MainResources870x1200.Resources._24);
                CardResources.Add(MainResources870x1200.Resources._25);
                CardResources.Add(MainResources870x1200.Resources._26);
                CardResources.Add(MainResources870x1200.Resources._27);
                CardResources.Add(MainResources870x1200.Resources._28);
                CardResources.Add(MainResources870x1200.Resources._29);
                CardResources.Add(MainResources870x1200.Resources._30);
                CardResources.Add(MainResources870x1200.Resources._31);
                CardResources.Add(MainResources870x1200.Resources._32);
                CardResources.Add(MainResources870x1200.Resources._33);
                CardResources.Add(MainResources870x1200.Resources._34);
                CardResources.Add(MainResources870x1200.Resources._35);
                CardResources.Add(MainResources870x1200.Resources._36);
                CardResources.Add(MainResources870x1200.Resources._37);
                CardResources.Add(MainResources870x1200.Resources._38);
                CardResources.Add(MainResources870x1200.Resources._39);
                CardResources.Add(MainResources870x1200.Resources._40);
                CardResources.Add(MainResources870x1200.Resources._41);
                CardResources.Add(MainResources870x1200.Resources._42);
                CardResources.Add(MainResources870x1200.Resources._43);
                CardResources.Add(MainResources870x1200.Resources._44);
                CardResources.Add(MainResources870x1200.Resources._45);
                CardResources.Add(MainResources870x1200.Resources._46);
                CardResources.Add(MainResources870x1200.Resources._47);
                CardResources.Add(MainResources870x1200.Resources._48);
                CardResources.Add(MainResources870x1200.Resources._49);
                CardResources.Add(MainResources870x1200.Resources._50);
                CardResources.Add(MainResources870x1200.Resources._51);
                CardResources.Add(MainResources870x1200.Resources._52);
                CardResources.Add(MainResources870x1200.Resources._53);
                CardResources.Add(MainResources870x1200.Resources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Loads resources for the resolution of 960x1440.
        /// </summary>
        public static void LoadResources960x1440()
        {
            try
            {
                Back = MainResources960x1440.Resources.back;
                CardResources.Add(MainResources960x1440.Resources._1);
                CardResources.Add(MainResources960x1440.Resources._2);
                CardResources.Add(MainResources960x1440.Resources._3);
                CardResources.Add(MainResources960x1440.Resources._4);
                CardResources.Add(MainResources960x1440.Resources._5);
                CardResources.Add(MainResources960x1440.Resources._6);
                CardResources.Add(MainResources960x1440.Resources._7);
                CardResources.Add(MainResources960x1440.Resources._8);
                CardResources.Add(MainResources960x1440.Resources._9);
                CardResources.Add(MainResources960x1440.Resources._10);
                CardResources.Add(MainResources960x1440.Resources._11);
                CardResources.Add(MainResources960x1440.Resources._12);
                CardResources.Add(MainResources960x1440.Resources._13);
                CardResources.Add(MainResources960x1440.Resources._14);
                CardResources.Add(MainResources960x1440.Resources._15);
                CardResources.Add(MainResources960x1440.Resources._16);
                CardResources.Add(MainResources960x1440.Resources._17);
                CardResources.Add(MainResources960x1440.Resources._18);
                CardResources.Add(MainResources960x1440.Resources._19);
                CardResources.Add(MainResources960x1440.Resources._20);
                CardResources.Add(MainResources960x1440.Resources._21);
                CardResources.Add(MainResources960x1440.Resources._22);
                CardResources.Add(MainResources960x1440.Resources._23);
                CardResources.Add(MainResources960x1440.Resources._24);
                CardResources.Add(MainResources960x1440.Resources._25);
                CardResources.Add(MainResources960x1440.Resources._26);
                CardResources.Add(MainResources960x1440.Resources._27);
                CardResources.Add(MainResources960x1440.Resources._28);
                CardResources.Add(MainResources960x1440.Resources._29);
                CardResources.Add(MainResources960x1440.Resources._30);
                CardResources.Add(MainResources960x1440.Resources._31);
                CardResources.Add(MainResources960x1440.Resources._32);
                CardResources.Add(MainResources960x1440.Resources._33);
                CardResources.Add(MainResources960x1440.Resources._34);
                CardResources.Add(MainResources960x1440.Resources._35);
                CardResources.Add(MainResources960x1440.Resources._36);
                CardResources.Add(MainResources960x1440.Resources._37);
                CardResources.Add(MainResources960x1440.Resources._38);
                CardResources.Add(MainResources960x1440.Resources._39);
                CardResources.Add(MainResources960x1440.Resources._40);
                CardResources.Add(MainResources960x1440.Resources._41);
                CardResources.Add(MainResources960x1440.Resources._42);
                CardResources.Add(MainResources960x1440.Resources._43);
                CardResources.Add(MainResources960x1440.Resources._44);
                CardResources.Add(MainResources960x1440.Resources._45);
                CardResources.Add(MainResources960x1440.Resources._46);
                CardResources.Add(MainResources960x1440.Resources._47);
                CardResources.Add(MainResources960x1440.Resources._48);
                CardResources.Add(MainResources960x1440.Resources._49);
                CardResources.Add(MainResources960x1440.Resources._50);
                CardResources.Add(MainResources960x1440.Resources._51);
                CardResources.Add(MainResources960x1440.Resources._52);
                CardResources.Add(MainResources960x1440.Resources._53);
                CardResources.Add(MainResources960x1440.Resources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Determins which resources to load based on the size of everything.
        /// </summary>
        public static void LoadResources()
        {
            try
            {
                Size ScreenSize = Util.GetScreenSize(VariableStorage.TheForm);

                if (ScreenSize.Height > 1440)
                {
                    LoadResourcesHighestRes();
                    return;
                }

                if (ScreenSize.Height <= 1440 && ScreenSize.Height > 1200)
                {
                    LoadResources960x1440();
                    return;
                }

                if (ScreenSize.Height <= 1200)
                {
                    LoadResources870x1200();
                    return;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Kicks off the necessary steps to load all resources needed.
        /// </summary>
        public static void LoadResourcesHighestRes()
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