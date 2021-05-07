using System;

namespace RSSTweeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string feedURI = "https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=10";
            RSSFeed newFeed = RSSFetch.readFeed(feedURI);
            Console.WriteLine(newFeed);
            foreach(RSSItem item in newFeed.items)
            {
                Console.WriteLine(HTMLContentHandler.StripHtml(item.description));
                var blah = HTMLContentHandler.GetImageURIs(item.description);
                foreach(string uri in blah)
                {
                    Console.WriteLine("  " + uri);
                }
            }
        }

    }
}
