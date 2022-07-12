// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using System.Threading.Tasks;
using Tweetinvi.Parameters;

namespace ConsoleAppPoster
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string APIKey = "LJYAhdbDqZ7Z1DdYYl0EMDndL";
            string APISecret = "WTZl75Vyf9Yc11FOQcGe2eORCb2sex2pEUD7Hvl3FtwKL3gv2z";
            string AccessToken = "1684460798-7o8ivXqEdNaUvBPXqYZf1dTP31wsW6qktsd6JwP";
            string AccessSecret = "CQpCM7uEQG8awSV4zndRlUQSx6YnVF9Df5dQDjZsIqvfp";
            byte[] ImageBytes = File.ReadAllBytes("feelsgood.jpeg");
            TwitterClient UserClient = new TwitterClient(APIKey, APISecret, AccessToken, AccessSecret);
            IMedia ImageIMedia = await UserClient.Upload.UploadTweetImageAsync(ImageBytes);
            ITweet TweetWithImage = await UserClient.Tweets.PublishTweetAsync(new PublishTweetParameters("#feelsgood"){Medias = {ImageIMedia}});
        }
    }
}


