using System;

namespace NewsNow
{
    class Article
    {

        private string title, description, link, thumblink, guid, category, hashTag;
        private DateTime date;
        private const int TWEET_LENGTH = 136;

        public override string ToString()
        {
            int length = TWEET_LENGTH - (guid.Length + hashTag.Length);
            if (title.Length >= length)
            {
                title = title.Substring(0, (length - 3)) + "...";
            }
            return String.Format("{0}. {1} {2}", title, guid, hashTag);
        }

        public string HashTag
        {
            get
            {
                return hashTag;
            }
            set
            {
                hashTag = "#" + value.ToLower().Replace(" ", ""); ;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Guid
        {
            get
            {
                return guid;
            }

            set
            {
                guid = value;
            }
        }

        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }

        public string Thumblink
        {
            get
            {
                return thumblink;
            }

            set
            {
                thumblink = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
