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
        public static string path;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string consoleMessage = "Duplicate tweet, no action";

            if (args.Length <= 1)
            {
                Console.WriteLine("No URL passed for parsing or properties file missing, program will now exit");
                Environment.Exit(1);
            }

            path = args[1];
            XmlParser parser = new XmlParser(args[0]);

            Console.WriteLine("Loading news articles, please wait.......");
            tweet = parser.LatestHeadline();
            Console.WriteLine("Most recent article has beeen found:\n{0}", tweet);

            Twitter t = new Twitter();
            if (!t.isDuplicateTweet(tweet))
            {
                consoleMessage = t.Push(tweet);
            }
            Console.WriteLine(consoleMessage);
        }
    }
}