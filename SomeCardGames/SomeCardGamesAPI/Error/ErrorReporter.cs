using Microsoft.VisualStudio.TestTools.UnitTesting;
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace SomeCardGamesAPI.Error
{
    /// <summary>
    /// Automatically reports exceptions to my Github page.
    /// </summary>
    [TestClass]
    public static class ErrorReporter
    {
        /// <summary>
        /// Used by this to tell if we should fail a test because this is called.
        /// </summary>
        public static bool IsUnitTesting = false;

        /// <summary>
        /// Used to interact with Github.
        /// </summary>
        private static GitHubClient client = ConstructClient();

        /// <summary>
        /// Auto reports an error to my Github issues section.
        /// </summary>
        /// <param name="ex"></param>
        [TestMethod]
        public static void Report(Exception ex)
        {
            try
            {
                if (IsUnitTesting)
                {
                    throw ex;
                }

                string Report = GenerateReport(ex);
                string IssueTitle = "Error in method: " + ex.TargetSite.Name + ", error code: " + ex.HResult + " Assembly Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

                NewIssue ToReport = new NewIssue(IssueTitle) { Body = Report };
                //ToReport.Labels.Add("bug");

                var AllIssues = client.Issue.GetAllForRepository("SneakyTactician", "SomeCardGames").Result;

                List<Issue> Issues = AllIssues.ToList<Issue>();

                int i = 0;
                int siz = AllIssues.Count;

                while (i != siz)
                {
                    if (Issues.ElementAt(i).Title == ToReport.Title)
                    {
                        return;
                    }

                    i++;
                }
                var observable = client.Issue.Create("SneakyTactician", "SomeCardGames", ToReport);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                //Eat it
                if (IsUnitTesting)
                {
                    throw ex;
                }
                else
                {
                    //Eat it
                }
            }
        }

        /// <summary>
        /// Constructs and authenticates the github client.
        /// </summary>
        /// <returns></returns>
        private static GitHubClient ConstructClient()
        {
            try
            {
                GitHubClient ret = new GitHubClient(new ProductHeaderValue("SneakyTactician"));
                Credentials creds = new Credentials("SneakyTactician", Secure.GetGitToken());
                ret.Credentials = creds;
                return ret;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                //Eat it
                Debug.Assert(false);
                return null;
            }
        }

        /// <summary>
        /// Generates a report to post to Github's issue tracker for this game.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static string GenerateReport(Exception ex)
        {
            try
            {
                List<string> Report = new List<string>();

                #region Exception

                Report.Add("Exception:");
                Report.Add("Error code: " + ex.HResult);
                Report.Add("Error message: " + ex.Message);
                Report.Add("Exception hash code: " + ex.GetHashCode());
                Report.Add("Help link: " + ex.HelpLink);
                Report.Add("Method: " + ex.TargetSite.Name);
                Report.Add("Method hash code: " + ex.TargetSite.GetMethodBody().GetHashCode());
                Report.Add("Source: " + ex.Source);
                Report.Add("\r\n");
                Report.Add("Stack trace: ");
                Report.Add(ex.StackTrace);
                Report.Add("\r\n");
                Report.Add("Type: " + ex.GetType());

                #endregion Exception

                #region InnerExceptions

                if (ex.InnerException != null)
                {
                    Report.Add("\r\n");
                    Report.Add("Inner Exceptions: " + GenerateReportForException(ex.InnerException, 1));
                    Report.Add("\r\n");
                }

                #endregion InnerExceptions

                #region OtherInformation

                Report.Add("System information:");
                Report.Add("Is 64 bit OS: " + Environment.Is64BitOperatingSystem.ToString());
                Report.Add("Is 64 bit process: " + Environment.Is64BitProcess.ToString());
                Report.Add("OS version: " + Environment.OSVersion.VersionString);
                Report.Add("Processor count: " + Environment.ProcessorCount.ToString());
                Report.Add("System page size: " + Environment.SystemPageSize.ToString());
                Report.Add("Common Language Runtime version: " + Environment.Version.ToString());

                Process current = Process.GetCurrentProcess();

                Report.Add("\r\n");
                Report.Add("Some Card Games application information: ");
                Report.Add("Handles: " + current.HandleCount.ToString());
                Report.Add("Non paged system memory: " + current.NonpagedSystemMemorySize64.ToString());
                Report.Add("Paged memory: " + current.PagedMemorySize64.ToString());
                Report.Add("Max memory usage: " + current.PeakWorkingSet64.ToString());
                Report.Add("Is responding: " + current.Responding.ToString());
                Report.Add("Threads running: " + current.Threads.Count.ToString());
                try
                {
                    Report.Add("Screen Size: " + Utility.Util.GetScreenSize(Utility.VariableStorage.TheForm).ToString());
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    //Needed to catch this, as it goes outside of this class. If variable storage, or Util is too corrupt, this would fail.
                }

                #endregion OtherInformation

                return ConvertListToString(Report);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                //Eat it
                Debug.Assert(false);
                return "Report Generation Failed";
            }
        }

        /// <summary>
        /// Generates data about the inner exception in the exception.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="InnerException"></param>
        /// <returns></returns>
        public static string GenerateReportForException(Exception ex, int InnerException)
        {
            try
            {
                List<string> Report = new List<string>();

                int ExceptionCount = InnerException;

                Report.Add("\r\n");
                Report.Add("Inner Exception # " + InnerException.ToString() + ":");
                Report.Add("Error code: " + ex.HResult);
                Report.Add("Error message: " + ex.Message);
                Report.Add("Exception hash code: " + ex.GetHashCode());
                Report.Add("Help link: " + ex.HelpLink);
                Report.Add("Method: " + ex.TargetSite.Name);
                Report.Add("Method hash code: " + ex.TargetSite.GetMethodBody().GetHashCode());
                Report.Add("Source: " + ex.Source);
                Report.Add("\r\n");
                Report.Add("Stack trace: ");
                Report.Add(ex.StackTrace);
                Report.Add("\r\n");
                Report.Add("Type: " + ex.GetType());

                ExceptionCount++;

                if (ex.InnerException != null)
                {
                    Report.Add(GenerateReportForException(ex, ExceptionCount));
                }

                return ConvertListToString(Report);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                Debug.Assert(false);
                return "Error while generating inner exception data";
            }
        }

        /// <summary>
        /// Converts a list full of strings into one null terminated string.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ConvertListToString(List<string> list) //gotta roll out my own picture box
        {
            try
            {
                string[] Array = list.ToArray();
                string Rep = "";

                int i = 0;
                int size = Array.Count();

                while (i != size)
                {
                    string Current = Array[i];

                    if (Current != "\r\n")
                    {
                        Current += "\r\n";
                    }

                    Rep += Current;

                    i++;
                }

                return Rep;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Debug.Assert(false);
                return "Report generation failed";
            }
        }
    }
}