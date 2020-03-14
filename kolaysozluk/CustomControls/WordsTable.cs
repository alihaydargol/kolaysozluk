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
        private UserDictionary userDictionary;
        private List<(Label, Label, Label)> _labelTuples;
        private List<Label> _labels;
        private Ordering _lastOrder = Ordering.ByDate;
        private int _last = 0;
        private int _pageNumber = 0;

        public WordsTable()
        {
            InitializeComponent();
            _labelTuples = new List<(Label, Label, Label)>();
            _labels = new List<Label>();
            _labelTuples.Add((word1, meaning1, date1));
            _labelTuples.Add((word2, meaning2, date2));
            _labelTuples.Add((word3, meaning3, date3));
            _labelTuples.Add((word4, meaning4, date4));
            userDictionary = new UserDictionary(new JsonOperator(FilePaths.PermanentFiles.UserDictionary));
            if (userDictionary.Count <= 4)
                nextPage.Visible = false;

            previousPage.Visible = false;

            foreach (var textBoxTuple in _labelTuples)
            {
                _labels.Add(textBoxTuple.Item1);
                _labels.Add(textBoxTuple.Item2);
                _labels.Add(textBoxTuple.Item3);
            }
        }

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


        public void LoadDictionary()
        {
            var entries = userDictionary.FetchPage(_pageNumber);

            //no words in the dictionary
            if (entries.Count == 0)
                return;

            var lastWord = entries.Last();

            foreach (var labelTuple in _labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }

            int i = 0;


            for (int j = _last; j < entries.Count; j++)
            {
                _labelTuples[j].Item1.Text = entries[j].Word;
                _labelTuples[j].Item2.Text = entries[j].Meaning;
                _labelTuples[j].Item3.Text = entries[j].Date;
            }

            Task.Factory.StartNew(changeSize);
        }
        public void LoadSearchedWord(SortedDictionary<int, Entry> pairs)
        {
            //TODO : kayıtlı sözlükten arama yaptıktan sonra butunları geri açmam lazım
            nextPage.Visible = false;
            previousPage.Visible = false;
            foreach (var labelTuple in _labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }

            if (pairs.Count == 0)
                return;
            try
            {
                int i = 0;
                foreach (var entry in pairs.Values)
                {
                    if (i >= 4)
                        return;

                    _labelTuples[i].Item1.Text = entry.Word;
                    _labelTuples[i].Item2.Text = entry.Meaning;
                    _labelTuples[i++].Item3.Text = entry.Date;
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
                        catch (Exception)
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

            if (_pageNumber < userDictionary.MaxPage - 1)
            {
                previousPage.Visible = true;
                _pageNumber++;
            }

            if (_pageNumber == userDictionary.MaxPage - 1)
                nextPage.Visible = false;


            LoadDictionary();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            ParentForm.ActiveControl = null;

            if (_pageNumber > 0)
            {
                nextPage.Visible = true;
                _pageNumber--;
            }

            if (_pageNumber == 0)
                previousPage.Visible = false;

            LoadDictionary();
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
            Ordering order;
            switch (lb.Name)
            {
                case "wordLabel":
                    order = Ordering.ByWord;
                    userDictionary.Order(order);
                    if (_lastOrder != order)
                    {
                        _pageNumber = 0;
                        nextPage.Visible = true;
                        previousPage.Visible = false;
                        _lastOrder = order;
                    }
                    LoadDictionary();
                    break;
                case "meaningLabel":
                    order = Ordering.ByMeaning;
                    userDictionary.Order(order);
                    if (_lastOrder != order)
                    {
                        _pageNumber = 0;
                        nextPage.Visible = true;
                        previousPage.Visible = false;
                        _lastOrder = order;
                    }
                    LoadDictionary();
                    break;
                case "dateLabel":
                    order = Ordering.ByDate;
                    userDictionary.Order(order);
                    if (_lastOrder != order)
                    {
                        _pageNumber = 0;
                        nextPage.Visible = true;
                        previousPage.Visible = false;
                        _lastOrder = order;
                    }
                    userDictionary.Order(Ordering.ByDate);
                    LoadDictionary();
                    break;
            }
        }
    }
}
