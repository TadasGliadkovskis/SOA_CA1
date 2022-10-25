using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Extensions;
using Tweetinvi;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Helpers;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
/*
TWITTER KEYS
API KEY: J17bpvbztFvU9frxqzdBGmfnB
API KEY: SECRET: ETKMJA5FJ1IxJfDLwqaUjvgBNQbwzTGghRrqepYtVnf0BXMcP7
BEARER TOKEN: AAAAAAAAAAAAAAAAAAAAAJ%2BFiQEAAAAA4k01wLZaeUeMuMOJSSXjjwndAgM%3D5F3xh6ZRrxsr1NrlbMT2DvhZl7buBhOxb1QYDB7bltrttBgKV2
ACCESS TOKEN: 1450437000507662343-3VhZB5qwMC5L1bR3yFfbuoQADnWJPx
ACCESS TOKEN SECRET: wJBvnM3ElmH2vAsvQCH3vajLji72bmrkstKM7SOczmiyX
CLIENT ID: cFpVWTBlRlQ4MnVyQ1Z1QXJ3Mi06MTpjaQ
CLIENT SECRET: sa_OVOdR6ZLf5vfZci6XTwRvUO4N8dxyLu6OaZxfbruG3QMhRk
APP ID: 25789855
USERNAME d00229061T
    MUST HAVE: RETRIEVE BY ID. RETRIVE TWEETS FROM SPECIFIED USER. TWEET FROM APPLICATION. 
*/

namespace Tadas_Gliadkovskis_CA1
{
    public partial class TwitterApp : Form
    {
        public TwitterApp()
        {
            InitializeComponent();
        }

        private TwitterClient client = new TwitterClient("J17bpvbztFvU9frxqzdBGmfnB", "ETKMJA5FJ1IxJfDLwqaUjvgBNQbwzTGghRrqepYtVnf0BXMcP7", "1450437000507662343-3VhZB5qwMC5L1bR3yFfbuoQADnWJPx", "wJBvnM3ElmH2vAsvQCH3vajLji72bmrkstKM7SOczmiyX");

        private async void getRecentTweets_click(object sender, EventArgs e)
        {
            getTimeline();
        }

        private async void getTimeline()
        {
            

            if (userSearchBox.Text.IsEmpty())
            {
                MessageBox.Show("No such user!", "Error Retrieving User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            var userTimeline = await client.Timelines.GetUserTimelineAsync(userSearchBox.Text);

            for (int i = 0; i < numberOfTweets.TabIndex; i++)
            {
                MessageBox.Show("Tweet Text: " + userTimeline[i] + "\n Retweets: " + userTimeline[i].RetweetCount + "\n Likes: " + userTimeline[i].FavoriteCount);
            }
        }
        //Summary:
        // this returns an array of ITweet objects and can be easily  iterated over it with a for loop
        // Show the tweets text, Retweets and Likes

        private void publishTweet(object sender, EventArgs e)
        {
            var tweetContents = publishTweetTextBox.Text;
            if (tweetContents.Length == 0)
            {
                MessageBox.Show("Need to have tweet contents", "Error Publishing Tweet", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            client.Tweets.PublishTweetAsync(tweetContents);
            MessageBox.Show("Tweet Complete:", "Tweet Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Summary:
        // Emulating the twitter tweet box check that there is text before trying to tweet
        // will tweet to account "d00229061T"

        private void updateCharacterCount(object sender, EventArgs e)
        {
            int charCount = 180 - publishTweetTextBox.Text.Length;
            characterCount.Text = charCount.ToString();
        }

        private async void retrieveUserName()
        {
            var user = await client.Users.GetAuthenticatedUserAsync();
            MessageBox.Show("Current User: " + user.ToString(), "User twitter tag", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void getTweedById()
        {
            var tweet = await client.Tweets.GetTweetAsync(1583067836313837568);
            MessageBox.Show("Example Tweet: "+tweet.ToString(), "Tweet Retrieved by ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
