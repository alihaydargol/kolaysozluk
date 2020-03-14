using kolaysozluk.FileOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolaysozluk.Dictionary
{
    class UserDictionary
    {
        public List<Entry> Entries { get; set; }
        public int Count => Entries.Count;
        public int MaxPage => (int)Math.Ceiling((decimal)Entries.Count/ 4);

        private Operator _opr;
        public UserDictionary(Operator opr)
        {
            _opr = opr;
            Entries = _opr.LoadFile();
            Order(Ordering.ByDate);
        }

        public void Order(Ordering order)
        {
            switch (order)
            {
                case Ordering.ByWord:
                    Entries = Entries.OrderBy(x => x.Word).ToList();
                    break;
                case Ordering.ByMeaning:
                    Entries = Entries.OrderBy(x => x.Meaning).ToList();
                    break;
                case Ordering.ByDate:
                    Entries = Entries.OrderBy(x => DateTime.Parse(x.Date)).ToList();
                    break;
            }
        }

        public List<Entry> FetchPage(int page)
        {
            List<Entry> entries = new List<Entry>();

            for (int i = page * 4; i < page * 4 + 4; i++)
            {
                if (i >= Count)
                    return entries;

                entries.Add(Entries[i]);
            }
            return entries;
        }


    }
}
