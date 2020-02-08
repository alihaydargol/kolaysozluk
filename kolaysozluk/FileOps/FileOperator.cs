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
        public string CombinedPath { get;}
        private readonly string _filePath;
        private readonly string _name;

        public FileOperator(string path,string name)
        {
            _filePath = path;
            _name = name;
            CombinedPath = Path.Combine(path, name);
        }

        public FileOperator(string combinedPath)
        {
            var lastIndex = combinedPath.LastIndexOf("\\");
            _filePath = combinedPath.Substring(0, lastIndex);
            _name = combinedPath.Substring(lastIndex+1);
            CombinedPath = combinedPath;
        }

        public void SaveToFile(string content)
        {
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(_filePath);
            }
            
            File.WriteAllText(CombinedPath,content);
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

        public List<string> LoadFile()
        {
            return File.ReadAllLines(CombinedPath).ToList();
        }

        public static void DeleteTemporaryFiles()
        {
            var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(myDocumentsPath,"kolaysozluk", FilePaths.TemporaryFiles.LastPage);
            File.Delete(path);
        }

    }
}
