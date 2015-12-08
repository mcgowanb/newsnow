using System;

namespace NewsNow
{
    class Article
    {
        private string title, description, link, thumblink, guid, date, category;

        public override string ToString()
        {
            return String.Format("{0} : {2} : {3} : {4}", title, description, guid, date, category);
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
                return Date;
            }

            set
            {
                title = value;
            }
        }

        public string Date
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
