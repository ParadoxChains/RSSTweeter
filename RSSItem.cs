using System;

namespace RSSTweeter
{
    public class RSSItem : IComparable
    {
        private string title;
        private string link;
        private string description;
        private string author;
        private string category;
        private string comments;
        private DateTime pubDate;
        private string guid;

        public RSSItem(string title, string link, string description, string author, string category, string comments, string pubDate, string guid)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.link = link ?? throw new ArgumentNullException(nameof(link));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.author = author ?? throw new ArgumentNullException(nameof(author));
            this.category = category ?? throw new ArgumentNullException(nameof(category));
            this.comments = comments ?? throw new ArgumentNullException(nameof(comments));
            this.pubDate = DateTime.Parse(pubDate ?? throw new ArgumentNullException(nameof(pubDate))) ;
            this.guid = guid ?? throw new ArgumentNullException(nameof(guid));
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
    }
}
