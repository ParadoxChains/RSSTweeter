using System;
using System.Threading.Tasks;
using CodeHollow.FeedReader;


namespace RSSTweeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string feedURI = "https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=5";
            RSSFeed newFeed = RSSFetch.readFeed(feedURI);
            Console.WriteLine(newFeed);
            
        }

    }
}
