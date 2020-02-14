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

namespace kolaysozluk.CustomControls
{
    public partial class WordsTable : UserControl
    {
        private List<(Label, Label, Label)> labelTuples;
        private List<Label> labels;
        private int _last = 0;

        public WordsTable()
        {
            InitializeComponent();
            labelTuples = new List<(Label, Label, Label)>();
            labels = new List<Label>();
            labelTuples.Add((word1, meaning1, date1));
            labelTuples.Add((word2, meaning2, date2));
            labelTuples.Add((word3, meaning3, date3));
            labelTuples.Add((word4, meaning4, date4));

            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            var wordsCount = fOperator.LoadFile().Count;

            if (wordsCount <= 4)
                nextPage.Visible = false;

            previousPage.Visible = false;

            foreach (var textBoxTuple in labelTuples)
            {
                labels.Add(textBoxTuple.Item1);
                labels.Add(textBoxTuple.Item2);
                labels.Add(textBoxTuple.Item3);
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

        public void LoadDictionary(bool isNext, bool reset = false)
        {
            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            var words = fOperator.LoadFile();

            //no words in the dictionary
            if (words.Count == 0)
                return;

            if (words.Count <= 4)
                nextPage.Visible = false;
            else
            {
                nextPage.Visible = true;
            }


            var lastWord = words.Last();

            _last = reset ? 0 : _last;

            //it's the end of the words in the dictionary, can't go to next page unless it's reseted to begin
            if (word1.Text == lastWord.Substring(0, lastWord.IndexOf('/')) && isNext && !reset)
                return;


            foreach (var labelTuple in labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }

            /*

             */

            string temp;
            int i = 0;
            switch (isNext)
            {
                case true:

                    for (int j = _last; j < words.Count; j++)
                    {

                        // data format  -> word/meaning/time
                        // good/güzel/11.11.2011 11:11:11
                        temp = words[j].Substring(0, words[j].IndexOf('/'));
                        labelTuples[i].Item1.Text = temp; // word
                        words[j] = words[j].Replace(temp + "/", string.Empty);

                        temp = words[j].Substring(0, words[j].IndexOf('/'));
                        labelTuples[i].Item2.Text = temp; // meaning
                        words[j] = words[j].Replace(temp + "/", string.Empty);

                        temp = words[j].Substring(0, words[j].Length).Replace(" ", "  "); // time
                        labelTuples[i].Item3.Text = temp;

                        i++;

                        if (i >= labelTuples.Count)
                        {
                            _last = i;
                            break;
                        }
                    }
                    break;
                case false:
                    for (int j = _last - 4; j < 4; j++)
                    {
                        // data format  -> word/meaning/time
                        // good/güzel/11.11.2011 11:11:11
                        temp = words[j].Substring(0, words[j].IndexOf('/'));
                        labelTuples[i].Item1.Text = temp; // word
                        words[j] = words[j].Replace(temp + "/", string.Empty);

                        temp = words[j].Substring(0, words[j].IndexOf('/'));
                        labelTuples[i].Item2.Text = temp; // meaning
                        words[j] = words[j].Replace(temp + "/", string.Empty);

                        temp = words[j].Substring(0, words[j].Length).Replace(" ", "  "); // time
                        labelTuples[i].Item3.Text = temp;

                        i++;

                        if (i >= labelTuples.Count)
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
            foreach (var labelTuple in labelTuples)
            {
                labelTuple.Item1.Text = string.Empty;
                labelTuple.Item2.Text = string.Empty;
                labelTuple.Item3.Text = string.Empty;
            }

            var sortedLines = lines.OrderBy(s => s.Last()).ToArray();

            try
            {
                for (int i = 0; i < labelTuples.Count; i++)
                {
                    var temp = "";
                    var ln = sortedLines[i];

                    temp = ln.Substring(0, lines[i].IndexOf('/'));
                    labelTuples[i].Item1.Text = temp;
                    ln = ln.Replace(temp + "/", string.Empty);
                    temp = ln.Substring(0, ln.IndexOf('/'));
                    labelTuples[i].Item2.Text = temp;
                    ln = ln.Replace(temp + "/", string.Empty);
                    temp = ln.Substring(0, ln.Length-1).Replace(" ", "  ");
                    labelTuples[i].Item3.Text = temp;

                }

            }
            catch (Exception e)
            {

            }

        }
        public void changeSize()
        {
            foreach (var lab in labels)
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

        private void textBoxSizeChanged(object sender, EventArgs e)
        {
            //changeSize(sender as TextBox);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            previousPage.Visible = true;
            ParentForm.ActiveControl = null;
            LoadDictionary(true);
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            ParentForm.ActiveControl = null;
            LoadDictionary(false);
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
    }
}
