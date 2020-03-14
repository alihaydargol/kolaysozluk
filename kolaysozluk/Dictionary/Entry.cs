using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.Dictionary
{
    public class Entry
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string Date { get; set; }


        public override string ToString()
        {
            
            var message = string.Empty;

            if (string.IsNullOrEmpty(Word))
                message += "Word property is empty";

            if (string.IsNullOrEmpty(Meaning))
            {
                _ = string.IsNullOrEmpty(message) ? message += "Meaning property is empty" : message += ", Meaning property is empty";
            }

            if (string.IsNullOrEmpty(Date))
            {
                _ = string.IsNullOrEmpty(message) ? message += "Date property is empty" : message += ", Date property is empty";
            }

            if (!string.IsNullOrEmpty(message))
                throw new Exception(message);

            var str = JsonConvert.SerializeObject(this);

            return str;
        }
    }
}
