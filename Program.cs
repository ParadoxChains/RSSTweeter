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
            RSSFetch.readFeed();
        }

    }
}
