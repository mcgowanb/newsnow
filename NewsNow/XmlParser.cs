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
        private XmlNodeList list;

        public XmlParser(string url) {
            this.url = url;
            this.doc = new XmlDocument();
        }

        public void process() {
            doc.Load(url);
            list = doc.GetElementsByTagName("item");
            Console.WriteLine("sdfs");

        }
    }

}
