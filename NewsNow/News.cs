using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TweetSharp;

namespace NewsNow
{
    class News
    {
        private static string tweet;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            XmlParser parser = new XmlParser(args[0]);

            Console.WriteLine("Loading news articles, please wait.......");

            tweet = parser.LatestHeadline();
            Console.WriteLine("Most recent article has beeen found:\n{0}\nPushing to twitter", tweet);

            Twitter t = new Twitter();
            TwitterStatus result = t.Push(tweet);

            if (result != null)
            {
                Console.WriteLine("Tweet sent successfully");
            }
            else Console.WriteLine("Duplicate tweet, no futher action");


        }
    }
}