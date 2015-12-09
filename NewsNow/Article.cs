using System;

namespace NewsNow
{
    class Article
    {
        private string title, description, link, thumblink, guid, category, hashTag;
        private DateTime date;

        public override string ToString()
        {
            return String.Format("{0}. {3:dd/MM/yy HH:mm:ss} {2} {5}", title, description, guid, date, category, hashTag);
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
