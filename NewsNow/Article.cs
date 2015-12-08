using System;

namespace NewsNow
{
    class Article
    {
        private string title, content, link, thumblink, guid;

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", title, content, guid);
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
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
    }
}
