using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SomeCardGames.Error
{
    public static class ErrorReporter
    {
        public static void Report(Exception ex)
        {
            WebRequest request = WebRequest.Create("https://api.github.com/repos/SneakyTactician/SomeCardGames/issues ");
            request.Method = "POST";
            string postData = "{'title':'exception occured!', 'body':'{0}','assignee': 'SneakyTactician'}";
            byte[] byteArray = Encoding.UTF8.GetBytes(/*string.Format(postData, ex)*/"a");
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
         }
    }
}