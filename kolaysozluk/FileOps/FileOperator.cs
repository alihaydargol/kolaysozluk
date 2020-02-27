using kolaysozluk.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.FileOps
{
    class FileOperator
    {
        public string CombinedPath { get; }
        private readonly string _filePath;
        private readonly string _name;

        public FileOperator(string path, string name)
        {
            _filePath = path;
            _name = name;
            CombinedPath = Path.Combine(path, name);
        }

        public FileOperator(string combinedPath)
        {
            var lastIndex = combinedPath.LastIndexOf("\\");
            _filePath = combinedPath.Substring(0, lastIndex);
            _name = combinedPath.Substring(lastIndex + 1);
            CombinedPath = combinedPath;
        }


        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void SaveToFile(string content)
        {
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(_filePath);
            }

            File.WriteAllText(CombinedPath, content);
        }

        public void AppendFile(string content)
        {
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(_filePath);
            }

            using (StreamWriter sw = File.AppendText(CombinedPath))
            {
                sw.WriteLine(content);
            }
        }

       /* public List<string> LoadFile()
        {
            if (File.Exists(CombinedPath))
                return File.ReadAllLines(CombinedPath).ToList();

            using (var f = File.Create(CombinedPath))
                return new List<string>();
        }*/


        public List<Entry> LoadFile()
        {
            List<Entry> entries = new List<Entry>();
            if (File.Exists(CombinedPath))
            {
                using(StreamReader sr = new StreamReader(CombinedPath))
                {
                    Entry entry;
                    string line = "";
                    string temp = "";

                    while (!sr.EndOfStream)
                    {
                        entry = new Entry();
                        line = sr.ReadLine();
                        temp = line.Substring(0, line.IndexOf('/'));
                        entry.Word = temp;
                        line = line.Replace(temp + '/', string.Empty);
                        temp = line.Substring(0, line.IndexOf('/'));
                        entry.Meaning = temp;
                        temp = line.Replace(temp + '/', string.Empty);
                        entry.Date = temp;
                        entries.Add(entry);
                    }
                }
                return entries;
            }

            using (var f = File.Create(CombinedPath))
                return new List<Entry>();
        }

        public static void DeleteTemporaryFiles()
        {
            var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(myDocumentsPath, "kolaysozluk", FilePaths.TemporaryFiles.LastPage);
            File.Delete(path);
        }

    }
}
