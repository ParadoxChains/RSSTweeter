using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.ServiceModel;
using System.Xml;
using CodeHollow.FeedReader;

namespace RSSTweeter
{
    class RSSFetch
    {
        public static async Task<int> readFeed()
        {
            /*Rss20FeedFormatter feedFormatter = new Rss20FeedFormatter();
            XmlReader rssReader = XmlReader.Create("https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=5");
            (feedFormatter.CanRead(rssReader))
            {
                feedFormatter.ReadFrom(rssReader);
                rssReader.Close();
                Console.Write(feedFormatter);
            }*/
            var feed = await FeedReader.ReadAsync("https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=1");
            Console.WriteLine("Feed Title: " + feed.Title);
            Console.WriteLine("Feed Description: " + feed.Description);
            Console.WriteLine("Feed Image: " + feed.ImageUrl);
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title + " - " + item.Link);
            }
            return 1;
        }
    }
}
