using System;

namespace RSSTweeter
{
    public class RSSItem : IComparable
    {
        public string title;
        public string link;
        public string description;
        public DateTime pubDate;

        public RSSItem(string title, string link, string description, string pubDate)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.link = link ?? throw new ArgumentNullException(nameof(link));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.pubDate = DateTime.Parse(pubDate);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            RSSItem otherItem = obj as RSSItem;
            if (otherItem != null)
                return this.pubDate.CompareTo(otherItem.pubDate);
            else
                throw new ArgumentException("Object is not a RSSItem");
        }

        public override string ToString()
        {
            return "Item Title: " + title +
                "\n  Item Link: " + link +
                "\n  Item Descrption: " + description +
                "\n  Item Publishing Date: " + pubDate;
        }
    }
}
