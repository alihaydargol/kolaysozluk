using kolaysozluk.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.FileOps
{
    public abstract class Operator
    {
        public string CombinedPath { get; }
        private readonly string FilePath;
        private readonly string Name;

        public Operator(string path, string name)
        {
            FilePath = path;
            Name = name;
            CombinedPath = Path.Combine(path, name);
            CreateDirectory(CombinedPath);
        }

        public Operator(string combinedPath)
        {
            var lastIndex = combinedPath.LastIndexOf("\\");
            FilePath = combinedPath.Substring(0, lastIndex);
            Name = combinedPath.Substring(lastIndex + 1);
            CombinedPath = combinedPath;
            CreateDirectory(FilePath);
        }

        public static void DeleteTemporaryFiles()
        {
            var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = FilePaths.TemporaryFiles.LastPage;
            File.Delete(path);
        }
        private void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void SaveToFile(string content)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            File.WriteAllText(CombinedPath, content);
        }

        public void AppendFile(string content)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            using (StreamWriter sw = File.AppendText(CombinedPath))
            {
                sw.WriteLine(content);
            }
        }

        public abstract List<Entry> LoadFile();
    }
}
