using System;
using TweetSharp;

namespace NewsNow
{
    class Twitter
    {

        private string consumerKey, consumerSecret, accessToken, accessTokenSecret;

        public Twitter()
        {
            this.accessToken = "2354002902-u5HrSHdGgG16KI9bAEwYd9QHBRdW2SXNm0TRhhb";
            this.accessTokenSecret = "sUu6YaAgNQGSupJokOjStpmSsVYEQcT7TL4olqJSBTWgL";
            this.consumerKey = "Wvctm3WD477z0omUJ0icHQ";
            this.consumerSecret = "0YFXJwvVzfSPfCXtlYZHQ16rG9VnRJ463MDZGEJc8gg";
        }

        public TwitterStatus push(string tweet)
        {
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);

            TwitterStatus status = service.SendTweet(new SendTweetOptions { Status = tweet });

            return status;
        }
    }
}
