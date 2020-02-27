using CefSharp;
using CefSharp.WinForms;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using kolaysozluk.FileOps;
using kolaysozluk.Logger;
using kolaysozluk.Menu;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using ThreadState = System.Threading.ThreadState;
using Timer = System.Threading.Timer;
using kolaysozluk.Web;
using kolaysozluk.CustomControls;

namespace kolaysozluk
{

    public partial class Form1 : Form
    {
        private enum WebDictionary
        {
            Tureng,
            MerriamWebster,
            Cambridge,
        }

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        const int MYACTION_HOTKEY_ID = 1;

        private bool _mouseDown;
        private Point _lastLocation;
        private WebDictionary _dictionary = WebDictionary.Tureng;
        private bool isListing;

        public Form1()
        {

            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            //generate mydocument files

            FilePaths.CreateRequirement();

            //keyboard hotkey
            //alt = 1 ,ctrl = 2, shift = 4, win = 8
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 3, (int)Keys.D); // ctrl + alt + d

            // Webrowser
            var settings = new CefSettings();
            settings.SetOffScreenRenderingBestPerformanceArgs();
            Cef.Initialize(settings);
            chromWebBrowser.MenuHandler = new MenuHandler();

            //lose focus
            ActiveControl = chromWebBrowser;

            //exit button
            exitButton.Click += ExitButton_Click;

            //notifyIcon
            sytemTrayNI.MouseDoubleClick += SytemTrayNI_MouseDoubleClick;
            sytemTrayNI.Visible = false;


            chromWebBrowser.LoadHtml(Properties.Resources.startup_page);
            
            //searchbox
            searchBox.KeyDown += SearchBox_KeyDown;

            this.SizeChanged += Form1_SizeChanged;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Task.Factory.StartNew(wordsTable.changeSize);
            //wordsTable.changeSize();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }


        // probably ok 
        #region OK


        private void TopPanel_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void SytemTrayNI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            sytemTrayNI.Visible = false;
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            Hide();
            sytemTrayNI.Visible = true;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point((this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 2;
            bool handled = false;

            //resize
            Size formSize = this.Size;

            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {


                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);


                if (Size.Width < 500 || Size.Height < 500)
                {
                    if (Size.Width < 500)
                        Size = new Size(500, Size.Height);
                    if (Size.Height < 500)
                        Size = new Size(Size.Width, 500);
                }

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
                    {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
                    {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
                };

                foreach (var hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }



            // hotkey 
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                Thread.Sleep(300);
                SendKeys.SendWait("^(c)");
                Thread.Sleep(300);

                searchBox.Text = Clipboard.GetText();

                this.Activate();
                this.BringToFront();
                this.Show();
            }

            if (!handled)
                base.WndProc(ref m);
        }

        private void FetchData()
        {

            var uri = new Uri("https://tureng.com/tr/turkce-ingilizce/");
            var content = "";
            var inputText = searchBox.Text;
            var meaning = "";

            try
            {
                var html = "";
                var css = "";
                HtmlNode node;

                switch (_dictionary)
                {
                    case WebDictionary.Tureng:
                        uri = new Uri("https://tureng.com/tr/turkce-ingilizce/" + inputText);
                        var turengBot = new Bot(uri, new WebClient());
                        node = turengBot.SelectNode("//*[@id='englishResultsTable']");
                        html = node.OuterHtml.Replace("href=", "");
                        meaning = turengBot.SelectNode("//*[@id='englishResultsTable']/tr[4]/td[4]/a").InnerHtml;
                        css = "\n<style type=\"text/css\">\n" +
                              Properties.Resources.css +
                              "\n</style> ";
                        content = html + css;
                        
                        break;

                    case WebDictionary.MerriamWebster:

                        uri = new Uri("https://www.merriam-webster.com/dictionary/" + inputText);
                        var merriamBot = new Bot(uri, new WebClient());
                        merriamBot.ClearDocument("//div[@class='anchor-list']",
                            "//div[@id='synonyms-anchor']", "//a[@class='widget-button thesaurus hoverable']",
                            "//span[@id='in-sentences']", "//span[@id='on-web']", "//div[@class='on-web']",
                            "//div[@class='widget learn_more']", "//div[@class='widget more-from']",
                            "//div[@class='widget seen-and-heard-block']");
                        node = merriamBot.SelectNode("//div[@id='left-content']");
                        html = node.OuterHtml.Replace("href=", "");
                        css = "\n<style type=\"text/css\">\n" +
                              Properties.Resources.merriamcss +
                              "\n</style> ";
                        content = html + css;

                        break;

                    case WebDictionary.Cambridge:

                        //cambridge bot
                        uri = new Uri("https://dictionary.cambridge.org/tr/sözlük/ingilizce-türkçe/" + inputText);
                        var cambridgeBot = new Bot(uri, new WebClient());
                        cambridgeBot.ClearDocument("//div[@class='share rounded js-share']",
                            "//h3[@class='h4 txt-block txt-block--alt']",
                            "//div[@class='xref see_also margin-bottom']", "//div[@class='item']");
                        node = cambridgeBot.SelectNode(
                            "//div[@class='di $ entry-body__el entry-body__el--smalltop clrd js-share-holder']");
                        html = node.OuterHtml.Replace("href=", "");
                        css = "\n<style type=\"text/css\">\n" +
                              Properties.Resources.cambridgecss +
                              "\n</style> ";
                        content = html + css;

                        break;
                }

                FileOperator fileOperator;
                if (chromWebBrowser.InvokeRequired)
                {
                    chromWebBrowser.Invoke((MethodInvoker)delegate
                    {
                        chromWebBrowser.LoadHtml(css + html, uri.AbsoluteUri);
                        fileOperator = new FileOperator(FilePaths.TemporaryFiles.LastPage);
                        fileOperator.SaveToFile(content);
                        
                    });
                }
                
                meaning = WebUtility.HtmlDecode(meaning);
                fileOperator = new FileOperator(FilePaths.TemporaryFiles.LastWord);
                fileOperator.SaveToFile(inputText + "/" + meaning);
            }
            catch (WebException exception)
            {

                content = Properties.Resources.errorpage;
                content = content.Replace("info", "Internet yok yada baglanti kurulamadi");

                content = content.Replace("inserterrormessagehere",
                    uri.AbsoluteUri + "bulunamadi");
                content = content.Replace("insertexceptionhere", exception.ToString());

                if (chromWebBrowser.InvokeRequired)
                {
                    chromWebBrowser.Invoke((MethodInvoker)delegate
                    {
                        chromWebBrowser.LoadHtml(content);
                    });
                }
                else
                {
                    chromWebBrowser.LoadHtml(content);
                }

            }
            catch (NullReferenceException exception)
            {
                content = Properties.Resources.errorpage;
                content = content.Replace("info", "Aradidigin Kelimeyi Bulamadim");
                content = content.Replace("inserterrormessagehere", "Loglar " + FilePaths.PermanentFiles.Logs + " 'a kaydedildi.");
                content = content.Replace("insertexceptionhere", "Bir Seferlik Arama Butonuna Basarak Ara");
                LogOperator.Log(exception);

                if (chromWebBrowser.InvokeRequired)
                {
                    chromWebBrowser.Invoke((MethodInvoker)delegate
                    {
                        chromWebBrowser.LoadHtml(content);
                    });
                }
                else
                {
                    chromWebBrowser.LoadHtml(content);
                }

            }
        }

        #endregion


        private void SearchButton_Click(object sender, EventArgs e)
        {
            ActiveControl = searchBox;
            var inputText = searchBox.Text;

            if (string.IsNullOrWhiteSpace(inputText))
                return;

            Task.Factory.StartNew(FetchData);
            chromWebBrowser.BringToFront();



        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if(!isListing)
            {
                var str = searchBox.Text;
                str = str.Replace("\n", String.Empty);
                str = str.Replace("\r", String.Empty);
                str = str.Replace("\t", String.Empty);
                searchBox.Text = str;
                BringToFront();
                Show();
                textBoxTimer.Stop();
                textBoxTimer.Start();
            }
            else
            {
                var str = searchBox.Text;
                str = str.Replace("\n", String.Empty);
                str = str.Replace("\r", String.Empty);
                str = str.Replace("\t", String.Empty);

                var lines = File.ReadAllLines(FilePaths.PermanentFiles.UserDictionary);
                List<string> wordList = new List<string>();
                foreach (var line in lines)
                {
                    //line.Substring(0,line.IndexOf('/')) == str
                    var distance = WordsTable.LevenshteinDistance(line.Substring(0, line.IndexOf('/')), str);
                    if (distance < 3)
                    {
                        wordList.Add(line + distance);
                    }
                }


                wordsTable.LoadSearchedWord(wordList);
            }


        }

        private void SavedWords_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
          //  string[] words = null;
            isListing = true;
            dictionarySelectorPanel.Visible = false;
            wordsTable.LoadDictionary();

            if (!File.Exists(FilePaths.PermanentFiles.UserDictionary))
            {
                var content = Properties.Resources.errorpage;
                content = content.Replace("info", "Henuz bir kelime eklemedin!");
                content = content.Replace("inserterrormessagehere", "Arama yaparak sozluge bir seyler ekle!");
                content = content.Replace("insertexceptionhere", "");
                chromWebBrowser.LoadHtml(content);
                return;
            }

            wordsTable.BringToFront();
        }

        private void TurengButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            _dictionary = WebDictionary.Tureng;
            dictionarySelectorPanel.Visible = true;
            dictionarySelectorPanel.Location = turengButton.Location;
            chromWebBrowser.BringToFront();
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                Task.Factory.StartNew(FetchData);
            }
        }

        private void MerriamButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            _dictionary = WebDictionary.MerriamWebster;
            dictionarySelectorPanel.Visible = true;
            dictionarySelectorPanel.Location = merriamButton.Location;
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                Task.Factory.StartNew(FetchData);
            }
        }

        private void CambridgeButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            _dictionary = WebDictionary.Cambridge;
            dictionarySelectorPanel.Visible = true;
            dictionarySelectorPanel.Location = cambridgeButton.Location;
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                Task.Factory.StartNew(FetchData);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            FileOperator.DeleteTemporaryFiles();
            Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(int.Parse("9980FA", NumberStyles.HexNumber));

        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(int.Parse("9980FA", NumberStyles.HexNumber));

        }

        private void textBoxTimer_Tick(object sender, EventArgs e)
        {
            textBoxTimer.Stop();
            Task.Factory.StartNew(FetchData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alihaydargol/kolaysozluk");
        }
    }
}
