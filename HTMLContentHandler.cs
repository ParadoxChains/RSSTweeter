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
    }
}
