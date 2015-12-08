using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace NewsNow
{
    class GetNews
    {
        private static string url = @"http://www.thejournal.ie/feed/";

        static void Main(string[] args)
        {
         
            XmlParser parser = new XmlParser(url);

            parser.process();



            //string url = @"http://www.thejournal.ie/feed/";
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(url);

            //XmlNodeList heat_run_nodes = xmlDoc.GetElementsByTagName("link");

            //Console.WriteLine(heat_run_nodes.ToString());

        }
    }
}