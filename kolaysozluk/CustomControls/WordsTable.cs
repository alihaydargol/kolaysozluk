using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolaysozluk.FileOps;
using System.Collections;
using kolaysozluk.Dictionary;

namespace kolaysozluk.CustomControls
{
    public partial class WordsTable : UserControl
    {
        private List<(Label, Label, Label)> _labelTuples;
        private List<Label> _labels;
        private Listing _lastListing;
        private int _last = 0;
        public enum page
        {
            Next,
            Previous
        }

        public WordsTable()
        {
            InitializeComponent();
            _labelTuples = new List<(Label, Label, Label)>();
            _labels = new List<Label>();
            _labelTuples.Add((word1, meaning1, date1));
            _labelTuples.Add((word2, meaning2, date2));
            _labelTuples.Add((word3, meaning3, date3));
            _labelTuples.Add((word4, meaning4, date4));

            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            var wordsCount = fOperator.LoadFile().Count;

            if (wordsCount <= 4)
                nextPage.Visible = false;

            previousPage.Visible = false;

            foreach (var textBoxTuple in _labelTuples)
            {
                _labels.Add(textBoxTuple.Item1);
                _labels.Add(textBoxTuple.Item2);
                _labels.Add(textBoxTuple.Item3);
            }
        }


        #region Kelime Benzerliği
        public static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
        #endregion

        public void LoadDictionary(page to = page.Next, bool reset = false , Listing listing = Listing.ByDate)
        {
            List<Entry> entries;

            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            entries = fOperator.LoadFile();
            
            switch (listing)
            {
                case Listing.ByWord:
                    entries = entries.OrderBy(x => x.Word).ToList();
                    if (_lastListing != Listing.ByWord)
                        reset = true;
                    break;
                case Listing.ByMeaning:
                    entries = entries.OrderBy(x => x.Meaning).ToList();
                    if (_lastListing != Listing.ByMeaning)
                        reset = true;
                    break;
                case Listing.ByDate:
                    if (_lastListing != Listing.ByDate)
                        reset = true;
                    entries = entries.OrderBy(x => DateTime.Parse(x.Date)).ToList();
                    break;
            }

            _lastListing = listing;
            //no words in the dictionary
            if (entries.Count == 0)
                return;

            if (entries.Count <= 4)
                nextPage.Visible = false;
            else
            {
                nextPage.Visible = true;
            }


            var lastWord = entries.Last();

            _last = reset ? 0 : _last;

            //it's the end of the words in the dictionary, can't go to next page unless it's reseted to begin
            if (word1.Text == lastWord.Word && to == page.Next && !reset)
                return;


            foreach (var labelTuple in _labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }       

            string temp;
            int i = 0;

            switch (to)
            {
                case page.Next:

                    for (int j = _last; j < entries.Count; j++)
                    {

                        // data format  -> word/meaning/time
                        // good/güzel/11.11.2011 11:11:11
                        _labelTuples[i].Item1.Text = entries[j].Word;
                        _labelTuples[i].Item2.Text = entries[j].Meaning; 
                        _labelTuples[i].Item3.Text = entries[j].Date;

                        i++;

                        if (i >= _labelTuples.Count)
                        {
                            _last = i;
                            break;
                        }
                    }
                    break;
                case page.Previous:
                    for (int j = _last - 4; j < 4; j++)
                    {
                        // data format  -> word/meaning/time
                        // good/güzel/11.11.2011 11:11:11
                        _labelTuples[i].Item1.Text = entries[j].Word;
                        _labelTuples[i].Item2.Text = entries[j].Meaning;
                        _labelTuples[i].Item3.Text = entries[j].Date;

                        i++;

                        if (i >= _labelTuples.Count)
                        {
                            _last = i;
                            break;
                        }
                    }

                    break;
            }
            Task.Factory.StartNew(changeSize);
        }
        public void LoadSearchedWord(List<string> lines)
        {
            nextPage.Visible = false;
            previousPage.Visible = false;
            foreach (var labelTuple in _labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }

            if (lines.Count == 0)
                return;

            var sortedLines = lines.OrderBy(s => s.Last()).ToArray();

            try
            {
                int lenght;
                if (sortedLines.Length < 4)
                    lenght = sortedLines.Length;
                else
                    lenght = _labelTuples.Count;

                for (int i = 0; i < lenght; i++)
                {
                    var temp = "";
                    var ln = sortedLines[i];

                    temp = ln.Substring(0, lines[i].IndexOf('/'));
                    _labelTuples[i].Item1.Text = temp;
                    ln = ln.Replace(temp + "/", string.Empty);
                    temp = ln.Substring(0, ln.IndexOf('/'));
                    _labelTuples[i].Item2.Text = temp;
                    ln = ln.Replace(temp + "/", string.Empty);
                    temp = ln.Substring(0, ln.Length - 1).Replace(" ", "  ");
                    _labelTuples[i].Item3.Text = temp;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata", e.Message);
            }

        }
        public void changeSize()
        {
            foreach (var lab in _labels)
            {
                if (lab.InvokeRequired)
                {
                    lab.Invoke((MethodInvoker)delegate
                    {
                        SizeF extent = TextRenderer.MeasureText(lab.Text, lab.Font);

                        if (lab.Text == string.Empty)
                            return;

                        float hRatio = lab.Height / extent.Height;
                        float wRatio = lab.Width / extent.Width;
                        float ratio = (hRatio < wRatio) ? hRatio : wRatio;

                        float newSize = lab.Font.Size * ratio * 0.7f;
                        try
                        {
                            lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
                        }
                        catch (Exception e)
                        {
                            lab.Text = "haha çöktüm";
                        }
                    });
                }
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            previousPage.Visible = true;
            ParentForm.ActiveControl = null;
            LoadDictionary(listing: _lastListing);
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            ParentForm.ActiveControl = null;
            LoadDictionary(to: page.Previous, listing: _lastListing);
        }

        private void label_Click(object sender, EventArgs e)
        {

            var lb = sender as Label;
            var name = lb.Name;
            name = name.Substring(name.Length - 1);
            var form1 = ParentForm as Form1;
            var searchBox = form1.Controls.Find("searchBox", true).FirstOrDefault();

            switch (name)
            {
                case "1":
                    searchBox.Text = word1.Text;
                    break;
                case "2":
                    searchBox.Text = word2.Text;
                    break;
                case "3":
                    searchBox.Text = word3.Text;
                    break;
                case "4":
                    searchBox.Text = word4.Text;
                    break;
            }

            form1.Controls.Find("chromWebBrowser", true).FirstOrDefault().BringToFront();
        }

        private void labelOrder_Click(object sender, EventArgs e)
        {
            var lb = sender as Label;
            switch (lb.Name)
            {
                case "wordLabel":
                    LoadDictionary(listing: Listing.ByWord);
                    break;
                case "meaningLabel":
                    LoadDictionary(listing: Listing.ByMeaning);
                    break;
                case "dateLabel":
                    LoadDictionary(listing: Listing.ByDate);
                    break;
            }
        }
    }
}
