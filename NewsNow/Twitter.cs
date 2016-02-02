using System;
using TweetSharp;

namespace NewsNow
{
    class Twitter
    {

        private string consumerKey, consumerSecret, accessToken, accessTokenSecret;

        public Twitter()
        {
            this.accessToken = "4222277297-W7AxgyKv6jnGizv2y8mpCv8MpRpbqQLzaw2fOeJ";
            this.accessTokenSecret = "fHrQ4JKWhskLKfwJFl5ow7FGqD1BXRW9KrlmqXgcUxaSS";
            this.consumerKey = "Tg6Au8WRLlOtZQBjJI8Bk56QL";
            this.consumerSecret = "uo3AZ5TCuruw5A4yP1F0998ZoYSPkyw8gpu8zfqWw8HcUMQW9T";
        }

        public TwitterStatus Push(string tweet)
        {
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);
            double a = 3.4;
            TwitterStatus status = service.SendTweet(new SendTweetOptions { Status = tweet });

            return status;
        }
    }
}
