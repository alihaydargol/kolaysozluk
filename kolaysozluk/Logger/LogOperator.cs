using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kolaysozluk.FileOps;

namespace kolaysozluk.Logger
{
    static class LogOperator
    {
        private static readonly string _logPath = FilePaths.PermanentFiles.Logs;
        private static JsonOperator fileOperator = new JsonOperator(_logPath);
        public static void Log(Exception exception, string content = "")
        {
            var a = content ?? "";
            var log = "Time: " + DateTime.Now + "\n" +
                      "Message: " + exception.Message + "\n" +
                      "Stack Trace: " + exception.StackTrace + "\n" +
                      "Exception Type: " + exception.GetType().Name+ "\n" +
                      "" + ((content == string.Empty) ? content : "\n");

            fileOperator.AppendFile(log);
        }


    }
}
