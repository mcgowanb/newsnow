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
        private static string tweet;

        static void Main(string[] args)
        {
         
            XmlParser parser = new XmlParser(url);

            tweet = parser.process();
            Console.WriteLine(tweet);
           


        }
    }
}