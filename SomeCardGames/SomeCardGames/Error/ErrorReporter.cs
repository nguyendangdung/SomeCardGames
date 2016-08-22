using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Octokit;
using Octokit.Helpers;
using Octokit.Internal;
using System.Windows.Forms;

namespace SomeCardGames.Error
{
    /// <summary>
    /// Automatically reports exceptions to my github page.
    /// </summary>
    public static class ErrorReporter
    {
        /// <summary>
        /// Used to interact with github.
        /// </summary>
        private static GitHubClient client = ConstructClient();


        public static void Report(Exception ex)
        {
            string Report = GenerateReport(ex);
            string IssueTitle = "Error in method: " + ex.TargetSite.Name + ", error code: " + ex.HResult;

            NewIssue ToReport = new NewIssue(IssueTitle) {Body = Report};
            //ToReport.Labels.Add("bug");

            var AllIssues = client.Issue.GetAllForRepository("SneakyTactician", "SomeCardGames").Result;

            List<Issue> Issues = AllIssues.ToList<Issue>();

            int i = 0;
            int siz = AllIssues.Count;

            while (i != siz)
            {
                if (Issues.ElementAt(i).Title == ToReport.Title && Issues.ElementAt(i).Body == ToReport.Body)
                {
                    return;
                }

                i++;
            }
            var observable = client.Issue.Create("SneakyTactician", "SomeCardGames", ToReport);
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
                Credentials creds = new Credentials("SneakyTactician", "1d1a5321d3e944de7c603a0f27319ed31367a5b7");
                ret.Credentials = creds;
                return ret;
            }
            catch (Exception e)
            {

            }

            return null;
        }

        private static string GenerateReport(Exception ex)
        {
            string Report = "Exception:\r\n";
            Report += "Error code: " + ex.HResult + "\r\n";
            Report += "Error message: " + ex.Message + "\r\n";
            Report += "Exception hash code: " + ex.GetHashCode() + "\r\n";
            Report = "Help link: " + ex.HelpLink + "\r\n";
            Report += "Method: " + ex.TargetSite.Name + "\r\n";
            Report += "Method hash code: " + ex.TargetSite.GetMethodBody().GetHashCode() + "\r\n";
            Report += "Source: " + ex.Source + "\r\n";
            Report += "\r\n";
            Report += "Stack trace: " + "\r\n" + ex.StackTrace + "\r\n";
            Report += "\r\n";
            Report += "Type: " + ex.GetType() + "\r\n";
            if (ex.InnerException != null)
            {
                Report += "\r\n";
                Report += "Inner Exceptions: " + GenerateReport(ex.InnerException);
                Report += "\r\n";
            }

            return Report;
        }
    }
}