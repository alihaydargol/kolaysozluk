using kolaysozluk.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kolaysozluk.FileOps
{
    /// <summary>
    /// Behaves user dictionary as json file
    /// </summary>
    class JsonOperator : Operator
    {
        public JsonOperator(string path, string name) : base(path, name) { }

        public JsonOperator(string combinedPath) : base(combinedPath) { }

        public override List<Entry> LoadFile()
        {
            List<Entry> entries = new List<Entry>();
            try
            {
                using (StreamReader sr = new StreamReader(CombinedPath))
                {
                    Entry entry;

                    while (!sr.EndOfStream)
                    {
                        entry = new Entry();
                        entry = JsonConvert.DeserializeObject<Entry>(sr.ReadLine());
                        entries.Add(entry);
                    }
                }
                return entries;
            }
            catch (FileNotFoundException e)
            {
                return entries;
            }
            
        }
        
    }
}

