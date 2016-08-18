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
    public static class ErrorReporter
    {
        /// <summary>
        /// Used to interact with github.
        /// </summary>
        public static GitHubClient client = ConstructClient();


        public static void Report(Exception ex)
        {
            string Report;
            Report = "Help link: " + ex.HelpLink + "\r\n";
            Report += "Error code: " + ex.HResult + "\r\n";
            Report += "Error message: " + ex.Message + "\r\n";
            Report += "Source: " + ex.Source + "\r\n";
            Report += "\r\n";
            Report += "Stack trace: " + "\r\n" + ex.StackTrace + "\r\n";
            Report += "Method: " + ex.TargetSite.Name + "\r\n";

            string IssueTitle = "Error in method: " + ex.TargetSite.Name + ", error code: " + ex.HResult;

            NewIssue ToReport = new NewIssue(IssueTitle) {Body = Report};

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
        public static GitHubClient ConstructClient()
        {
            GitHubClient ret = new GitHubClient(new ProductHeaderValue("SneakyTactician"));
            Credentials creds = new Credentials("SneakyTactician", "SneakyTactician_101");
            ret.Credentials = creds;
            return ret;
        }
    }
}