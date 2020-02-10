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
        private List<(TextBox, TextBox, TextBox)> textBoxTuples;
        private int last = 0;
        public WordsTable()
        {
            InitializeComponent();
            textBoxTuples = new List<(TextBox, TextBox, TextBox)>();
            textBoxTuples.Add((word1, meaning1, date1));
            textBoxTuples.Add((word2, meaning2, date1));
            textBoxTuples.Add((word3, meaning3, date3));
            textBoxTuples.Add((word4, meaning4, date4));
        }

        private void LoadDictionary()
        {
            FileOperator fOperator = new FileOperator(FilePaths.PermanentFiles.UserDictionary);
            var words = fOperator.LoadFile();
            if(words.Count == 0)
                return;
            
            var lastWord = words.Last();
            if (word1.Text == lastWord.Substring(0, lastWord.IndexOf('/')))
                return;

            foreach (var textBoxTuple in textBoxTuples)
            {
                textBoxTuple.Item1.Text = string.Empty;
            }

            string temp;
            var i = 0;
            for (int j = last; j < words.Count; j++)
            {
                temp = words[j].Substring(0, words[j].IndexOf('/'));
                textBoxTuples[i++].Item1.Text = temp;
                last = i;
                if (i > 3)
                {
                    last = j + 1;
                    break;
                }

            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            LoadDictionary();
        }
    }
}
