﻿using System;
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
            Console.WriteLine("Context Menu Openned");

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
                var word = File.ReadAllText(FilePaths.TemporaryFiles.LastWord);
                var fileOperatorWrite = new FileOperator(FilePaths.PermanentFiles.UserDictionary);

                var words = File.ReadAllLines(FilePaths.PermanentFiles.UserDictionary);
                
                if (words.All(x => x.Substring(0,x.IndexOf("/")) != word))
                {
                    word += "/"+DateTime.Now;
                    fileOperatorWrite.AppendFile(word);
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
