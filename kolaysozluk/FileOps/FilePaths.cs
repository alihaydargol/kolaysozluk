﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.FileOps
{
    /// <summary>
    /// Contains Sub Classes That Holds Necessary File Paths
    /// </summary>
    public static class FilePaths
    {
        public static Environment.SpecialFolder SaveDirectory = Environment.SpecialFolder.MyDocuments;
        private const string DirName = "kolaysozluk";
        private const string LastPageFile = "lastPage.html";
        private const string DictionaryFile = "dictionary.jddb";
        private const string LastWordFile = "last_word.txt";
        private const string LogsFile = "logs.txt";

        private static readonly string _appPath = Path.Combine(Environment.GetFolderPath(SaveDirectory), DirName);

        /// <summary>
        /// ContainspPermament file paths
        /// </summary>
        public static class TemporaryFiles
        {
            public static readonly string LastPage = Path.Combine(_appPath, LastPageFile);
            public static readonly string LastWord = Path.Combine(_appPath, LastWordFile);
        }

        /// <summary>
        /// Contains permament file paths
        /// </summary>
        public static class PermanentFiles
        {
            public static readonly string UserDictionary = Path.Combine(_appPath, DictionaryFile);
            public static readonly string Logs = Path.Combine(_appPath, LogsFile);
        }

        /// <summary>
        /// Creates file saving directory
        /// </summary>
        public static void CreateSaveDirectory()
        {
            Directory.CreateDirectory(_appPath);
        }
    }
}
