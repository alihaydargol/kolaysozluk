using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace kolaysozluk.Web
{
    public class Bot
    {
        public Uri Uri { get; set; }
        public WebClient Client { get; set; }
        public HtmlDocument Document { get; set; }
        public string Content { get; set; }

        public Bot(Uri uri, WebClient client)
        {

            Uri = uri;
            Client = client;
            Client.Encoding = Encoding.UTF8;


            try
            {
                var html = Client.DownloadString(Uri);
                Document = new HtmlDocument();
                Document.LoadHtml(html);
            }
            catch (WebException e)
            {
                throw e;
            }
        }

        public HtmlNodeCollection SelectNodes(string xPath)
        {
            return Document.DocumentNode.SelectNodes(xPath);
        }

        public HtmlNode SelectNode(string xPath)
        {
            return Document.DocumentNode.SelectSingleNode(xPath);
        }

        public void ClearDocument(params string[] XPaths)
        {
            foreach (var xPath in XPaths)
            {
                try
                {
                    Document.DocumentNode.SelectSingleNode(xPath).Remove();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static HtmlNode LoadHtml(string html)
        {
            var doc = new HtmlDocument();
            return doc.DocumentNode;
        }

    }
}
