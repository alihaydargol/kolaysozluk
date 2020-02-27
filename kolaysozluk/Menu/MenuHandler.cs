using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using kolaysozluk.Dictionary;
using kolaysozluk.FileOps;

namespace kolaysozluk.Menu
{
    class MenuHandler : IContextMenuHandler
    {


        enum ContexMenuEnums
        {
            AddToDictionary = 26501
        }

        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters,
            IMenuModel model)
        {
            if (model.Count > 0)
                model.AddSeparator();

            model.AddItem(CefMenuCommand.AddToDictionary, "Sözlüğe Ekle");
        }

        private string DownloadPage(Uri uri)
        {
            var client = new WebClient();
            var html = client.DownloadString(uri);

            return html;
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters,
            CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == CefMenuCommand.AddToDictionary)
            {
                string word;
                try
                {
                    word = File.ReadAllText(FilePaths.TemporaryFiles.LastWord);
                }
                catch (DirectoryNotFoundException e)
                {
                    MessageBox.Show("Eklenecek Dizin Bulunamadı \n" + "Hata Mesajı:" + e.Message);
                    return false;
                }
                catch(FileNotFoundException e)
                {
                    MessageBox.Show("Bu Sayfayı Ekleyemezsin");
                    return false;
                }

                var userDictionary = new FileOperator(FilePaths.PermanentFiles.UserDictionary);

                var words = userDictionary.LoadFile();

                if (words.All(x => x.Word != word.Substring(0,word.IndexOf('/'))))
                {
                    word += "/" + DateTime.Now;
                    userDictionary.AppendFile(word);
                }
                else
                {
                    MessageBox.Show("Kelime Zaten Sözlüğe Eklenmmiş!");
                }
                return true;
            }

            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters,
            IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
