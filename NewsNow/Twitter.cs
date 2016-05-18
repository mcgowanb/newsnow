using System;
using System.Collections.Generic;
using TweetSharp;

namespace NewsNow
{
    class Twitter
    {
        private string consumerKey, consumerSecret, accessToken, accessTokenSecret;
        private Dictionary<string, string> properties = new Properties().LoadProperties();
        long userID;

        public Twitter()
        {
            properties = new Properties().LoadProperties();
            this.accessToken = properties["accessToken"];
            this.accessTokenSecret = properties["accessTokenSecret"];
            this.consumerKey = properties["consumerKey"];
            this.consumerSecret = properties["consumerSecret"];
            this.userID = Convert.ToInt64(properties["userID"]);
        }

        public String Push(string tweet)
        {
            SendTweetOptions options = new SendTweetOptions()
            {
                Status = tweet
            };
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);
            TwitterStatus result = service.SendTweet(options);
            string status;
            if (result == null)
            {
                status = service.Response.Error.ToString();
            }
            else
            {
                status = "Tweet successfully sent";
            }
            return status;
        }

        public Boolean isDuplicateTweet(string tweet)
        {
            Console.WriteLine("Checking twitter for duplicates..... please wait");
            Boolean duplicate = false;
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);
            var options = new ListTweetsOnUserTimelineOptions()
            {
                UserId = userID,
                Count = 5
            };

            IEnumerable<TwitterStatus> currentTweets = service.ListTweetsOnUserTimeline(options);
            string check = tweet.Substring(0, 20);
            foreach (var cTweet in currentTweets)
            {
                if ((cTweet.Text != null) && (cTweet.Text.Contains(check)))
                {
                    duplicate = true;
                    break;
                }
            }
            return duplicate;
        }
    }
}
