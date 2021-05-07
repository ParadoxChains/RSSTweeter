using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace RSSTweeter
{
    class HTMLContentHandler
    {
        public static string StripHtml(string html)
        {
            html = html.Replace(">", "> ");
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            string text = HttpUtility.HtmlDecode(doc.DocumentNode.InnerText);
            return Regex.Replace(text, @"\s+", " ").Trim();
        }
        public static List<string> GetImageURIs(string html)
        {
            html = html.Replace(">", "> ");
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            List<HtmlNode> imageNodes = null;
            imageNodes = (from HtmlNode node in doc.DocumentNode.SelectNodes("//img")
                          where node.Name == "img"
                          //&& node.Attributes["class"] != null
                          //&& node.Attributes["class"].Value.StartsWith("img_")
                          select node).ToList();
            List<string> uriList = new List<string>();
            foreach (HtmlNode node in imageNodes)
            {
                uriList.Add(node.Attributes["src"].Value);
            }
            return uriList;
        }
    }
}
