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

            foreach (var textBoxTuple in labelTuples)
            {
                labels.Add(textBoxTuple.Item1);
                labels.Add(textBoxTuple.Item2);
                labels.Add(textBoxTuple.Item3);
            }
        }


        public void LoadDictionary(bool isNext, bool reset = false)
        {
            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            var words = fOperator.LoadFile();

            //no words in the dictionary
            if (words.Count == 0)
                return;


            var lastWord = words.Last();

            _last = reset ? 0 : _last;

            //it's the end of the words in the dictionary, can't go to next page unless it's reseted to begin
            if (word1.Text == lastWord.Substring(0, lastWord.IndexOf('/')) && isNext && !reset)
                return;


            foreach (var textBoxTuple in labelTuples)
            {
                textBoxTuple.Item1.Text = string.Empty;
                textBoxTuple.Item2.Text = string.Empty;
                textBoxTuple.Item3.Text = string.Empty;
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
            ParentForm.ActiveControl = null;
            LoadDictionary(true);
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            ParentForm.ActiveControl = null;
            LoadDictionary(false);
        }
    }
}
