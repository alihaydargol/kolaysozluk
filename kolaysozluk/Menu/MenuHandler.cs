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
                Entry entry = new Entry();

                try
                {
                    var temp = File.ReadAllText(FilePaths.TemporaryFiles.LastWord);
                    var index = temp.IndexOf('/');
                    entry.Word = temp.Substring(0, index);
                    // "good/güzel" lenght == 9 ,  temp.IndexOf('/') == 5
                    entry.Meaning = temp.Substring(index + 1 , temp.Length - 1 - index);
                }
                catch (DirectoryNotFoundException e)
                {
                    MessageBox.Show("Eklenecek Dizin Bulunamadı \n" + "Hata Mesajı:" + e.Message);
                    return false;
                }
                catch(FileNotFoundException)
                {
                    MessageBox.Show("Bu Sayfayı Ekleyemezsin");
                    return false;
                }

                var userDictionary = new JsonOperator(FilePaths.PermanentFiles.UserDictionary);

                var words = userDictionary.LoadFile();
                if (words.All(x => x.Word != entry.Word))
                {
                    entry.Date = DateTime.Now.ToString();
                    userDictionary.AppendFile(entry.ToString());
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
