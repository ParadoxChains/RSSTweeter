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
        public static void readFeed()
        {
            var feed = FeedReader.Read("https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=5");
            Console.WriteLine("Feed Title: " + feed.Title);
            Console.WriteLine("Feed Description: " + feed.Description);
            Console.WriteLine("Feed Image: " + feed.ImageUrl);
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title + " - " + item.Description);
            }
        }
    }
}
