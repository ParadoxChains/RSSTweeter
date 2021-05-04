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
            readFeed();
        }
        public static void readFeed()
        {
            /*Rss20FeedFormatter feedFormatter = new Rss20FeedFormatter();
            XmlReader rssReader = XmlReader.Create("https://www.pftq.com/forums/?type=rss;action=.xml;boards=72;limit=5");
            (feedFormatter.CanRead(rssReader))
            {
                feedFormatter.ReadFrom(rssReader);
                rssReader.Close();
                Console.Write(feedFormatter);
            }*/
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
