using System;
using CodeHollow.FeedReader;

namespace RSSTweeter
{
    public class RSSFetch
    {
        public static RSSFeed readFeed(string feedURI)
        {
            var feed = FeedReader.Read(feedURI);

            if (feed!=null)
            {
                Console.WriteLine("Feed Title: " + feed.Title);
                Console.WriteLine("Feed Description: " + feed.Description);
                Console.WriteLine("Feed Image: " + feed.ImageUrl);
                RSSFeed newFeed = new RSSFeed(feed.Title, feed.Link, feed.Description);
                foreach (var item in feed.Items)
                {
                    Console.WriteLine("Item Title: " + item.Title +
                        "\n  Item Descrption: " + item.Description +
                        "\n  Item Publishing Date: " + item.PublishingDateString);
                    RSSItem newItem = new RSSItem(item.Title, item.Link, item.Description, item.PublishingDateString);
                    newFeed.addItem(newItem);
                }
                return newFeed;
            }
            else
            {
                throw new ApplicationException("Invalid Feed");
            }
        }
    }
}
