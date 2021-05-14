using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace RSSTweeter.Twitter
{
    class BaseTweet
    {
        private TwitterClient userClient;
        private ConfigurationLoader config;

        public BaseTweet()
        {
            config = new ConfigurationLoader();
            userClient = new TwitterClient(config.getAPIKey(), config.getAPISecretKey(), config.getAccessToken(), config.getAccessTokenSecret());
        }

        public void login()
        {

        }

        public async Task<Tweetinvi.Models.ITweet> tweetTextOnly(string tweetBody)
        {
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine("Logged in as: " + user);
            var tweet = await userClient.Tweets.PublishTweetAsync(tweetBody);
            Console.WriteLine("You published the tweet : " + tweet);
            var publishedTweet = await userClient.Tweets.GetTweetAsync(tweet.Id);
            return publishedTweet;
        }

        public async Task deleteTweet(Tweetinvi.Models.ITweet targetTweet)
        {
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine("Logged in as: " + user);
            await userClient.Tweets.DestroyTweetAsync(targetTweet);
            Console.WriteLine("You deleted the tweet : " + targetTweet);
        }
    }
}
