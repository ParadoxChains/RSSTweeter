using System;
using System.Collections.Generic;

namespace RSSTweeter
{
    public class RSSFeed
    {
        public string title;
        public string link;
        public string description;
        public List<RSSItem> items;

        public RSSFeed(string title)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public RSSFeed(string title, string link, string description) : this(title)
        {
            this.link = link ?? throw new ArgumentNullException(nameof(link));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            items = new List<RSSItem>();
        }

        public void addItem(RSSItem newItem)
        {
           if(newItem!=null)
            {
                items.Add(newItem);
                items.Sort();
            }
            else
            {
                throw new ArgumentNullException(nameof(newItem));
            }
        }

        public override string ToString()
        {
            string printout = "";
            printout += "Feed Title: " + title + "\nFeed Link: " + link + "\nFeed Description: " + description;
            foreach (var item in items)
            {
                printout += item.ToString();
            }
            return printout;
        }
    }
}
