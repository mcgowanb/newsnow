using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using TweetSharp;

namespace NewsNow
{
    class Twitter
    {
        private string consumerKey, consumerSecret, accessToken, accessTokenSecret;
        long userID;

        public Twitter()
        {
            this.accessToken = "4222277297-W7AxgyKv6jnGizv2y8mpCv8MpRpbqQLzaw2fOeJ";
            this.accessTokenSecret = "fHrQ4JKWhskLKfwJFl5ow7FGqD1BXRW9KrlmqXgcUxaSS";
            this.consumerKey = "Tg6Au8WRLlOtZQBjJI8Bk56QL";
            this.consumerSecret = "uo3AZ5TCuruw5A4yP1F0998ZoYSPkyw8gpu8zfqWw8HcUMQW9T";
            this.userID = 4222277297;
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
                if (cTweet.Text.Contains(check))
                {
                    duplicate = true;
                    break;
                }
            }
            return duplicate;
        }
    }
}
