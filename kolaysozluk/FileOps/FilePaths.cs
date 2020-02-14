using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.FileOps
{
    public static class FilePaths
    {
        public static Environment.SpecialFolder SaveDirectory = Environment.SpecialFolder.MyDocuments;
        private const string DirName = "kolaysozluk";
        private const string LastPageFile = "lastPage.html";
        private const string DictionaryFile = "dictionary.txt";
        private const string LastWordFile = "last_word.txt";
        private const string LogsFile = "logs.txt";

        private static readonly string _appPath = Path.Combine(Environment.GetFolderPath(SaveDirectory), DirName);

        public static class TemporaryFiles
        {
            public static readonly string LastPage = Path.Combine(_appPath, LastPageFile);
            public static readonly string LastWord = Path.Combine(_appPath, LastWordFile);
        }
        public static class PermanentFiles
        {
            public static readonly string UserDictionary = Path.Combine(_appPath, DictionaryFile);
            public static readonly string Logs = Path.Combine(_appPath, LogsFile);
        }

        public static void CreateRequirement()
        {
            Directory.CreateDirectory(_appPath);
        }
    }
}
