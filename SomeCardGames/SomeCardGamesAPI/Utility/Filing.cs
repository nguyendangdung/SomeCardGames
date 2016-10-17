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
		private static string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
		private static string ModulesFolderPath = RootPath + "\\Modules";
		private static string GolfFolderPath = ModulesFolderPath + "\\Golf";
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
			throw new NotImplementedException();
		}
	}
}
