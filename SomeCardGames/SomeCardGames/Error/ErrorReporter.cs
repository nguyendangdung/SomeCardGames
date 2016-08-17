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

        private static int GitRepoId //65702856
        {
            get
            {
                return 65702856;
            }
        }


        public static void Report(Exception ex)
        {
            //WebRequest request = WebRequest.Create("https://api.github.com/repos/SneakyTactician/SomeCardGames/issues ");
            //request.Method = "POST";
            //string postData = "{'title':'exception occured!', 'body':'{0}','assignee': 'SneakyTactician'}";
            //byte[] byteArray = Encoding.UTF8.GetBytes(/*string.Format(postData, ex)*/"a");
            //request.ContentLength = byteArray.Length;
            //Stream dataStream = request.GetRequestStream();
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //dataStream.Close();
            //WebResponse response = request.GetResponse();

            //This works
            // MessageBox.Show(client.Issue.Get("SneakyTactician", "SomeCardGames", 1).Result.Title);
            //MessageBox.Show(client.Repository.Get("SneakyTactician", "SomeCardGames").Result.Id.ToString());

            string Report;
            Report = "Help link: " + ex.HelpLink + "\r\n";
            Report += "Error code: " + ex.HResult + "\r\n";
            Report += "Error message: " + ex.Message + "\r\n";
            Report += "Source: " + ex.Source + "\r\n";
            Report += "\r\n";
            Report += "Stack trace: " + "\r\n" + ex.StackTrace + "\r\n";
            Report += "Method: " + ex.TargetSite.Name + "\r\n";

            NewIssue ToReport = new NewIssue("Error in method: " + ex.TargetSite.Name + ", error code: " + ex.HResult);
            ToReport.Assignee = "SneakyTactician";
            ToReport.Body = Report;
            ToReport.Labels.Add("Bug");
            int TheMileStone = 0;//client.Issue.Milestone.GetAllForRepository("SneakyTactician", "SomeCardGames").Result.GetEnumerator().Current.Number;
            ToReport.Milestone = TheMileStone;
            //client.Issue.GetAllForRepository("SneakyTactician", "SomeCardGames");

            MessageBox.Show(client.Issue.Create(GitRepoId, ToReport).IsCompleted.ToString());

            return;
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