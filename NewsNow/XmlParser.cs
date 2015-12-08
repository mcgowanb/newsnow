using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NewsNow
{
    class XmlParser
    {
        private string url;
        private XmlDocument doc;
        private List<Article> list;

        public XmlParser(string url) {
            this.url = url;
            this.doc = new XmlDocument();
            this.list = new List<Article>();
        }

        public void process() {
            doc.Load(url);

            XmlElement rootNode = doc.DocumentElement;
            XmlNodeList nodes = rootNode.SelectNodes("channel/item");

            foreach (XmlNode node in nodes) {
                Article art = new Article();
                art.Guid = node ["guid"].InnerText;
                art.Title = node["title"].InnerText;
                art.Date = node["pubDate"].InnerText;
                art.Description = node["description"].InnerText;
                art.Category = node["category"].InnerText;
                list.Add(art);
                Console.WriteLine(art);
            }


        }
    }

}
