using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using SomeCardGamesAPI.Error;

namespace SomeCardGamesAPI.Utility
{
	/// <summary>
	/// This class is used to manage all of the folders and file paths for this game, extensions, and it's modules.
	/// </summary>
	public static class Filing
	{
		/// <summary>
		/// Gets the location of the folder that this assembly is executing from.
		/// </summary>
		private static string RootPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
		private static string ModulesFolderPath = new Uri(RootPath + "\\Modules").LocalPath;
		private static string GolfFolderPath = new Uri(ModulesFolderPath + "\\Golf").LocalPath;
		public static string GolfSaveFolderPath = new Uri(GolfFolderPath + "\\Saves").LocalPath;
		/// <summary>
		/// Kicked off on startup to launch various processes.
		/// </summary>
		public static void DoMaintinence()
		{
			try
			{
				VerifyFoldersForChildModules();
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}
		}

		/// <summary>
		/// Makes sure that all internal card games have folders setup correctly.
		/// </summary>
		public static void VerifyFoldersForChildModules()
		{
			try
			{
				if (!Directory.Exists(ModulesFolderPath))
				{
					Directory.CreateDirectory(ModulesFolderPath);
				}
				//Golf
				if (!Directory.Exists(GolfFolderPath))
				{
					Directory.CreateDirectory(GolfFolderPath);
					if (!Directory.Exists(GolfSaveFolderPath))
					{
						Directory.CreateDirectory(GolfSaveFolderPath);
					}
				}
				//End
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}

		}

		/// <summary>
		/// Adds and verifies the folder structure of an external module.
		/// </summary>
		/// <param name="ModuleName"></param>
		public static void AddAndVerifyExternalModule(string ModuleName)
		{
			try
			{
				if (!Directory.Exists(new Uri(ModulesFolderPath + "\\" + ModuleName).LocalPath))
				{
					Directory.CreateDirectory(new Uri(ModulesFolderPath + "\\" + ModuleName).LocalPath);
					if (!Directory.Exists(new Uri(ModulesFolderPath + "\\" + ModuleName + "\\Saves").LocalPath))
					{
						Directory.CreateDirectory(new Uri(ModulesFolderPath + "\\" + ModuleName + "\\Saves").LocalPath);
					}
				}
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
			}
		}
	}
}