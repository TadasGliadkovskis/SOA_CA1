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

    MUST HAVE: RETRIEVE BY ID. RETRIVE TWEETS FROM SPECIFIED USER. TWEET FROM APPLICATION. 
*/

namespace Tadas_Gliadkovskis_CA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getSingleFruit(object sender, EventArgs e)
        {

        }

        private TwitterClient client = new TwitterClient("J17bpvbztFvU9frxqzdBGmfnB", "ETKMJA5FJ1IxJfDLwqaUjvgBNQbwzTGghRrqepYtVnf0BXMcP7", "1450437000507662343-3VhZB5qwMC5L1bR3yFfbuoQADnWJPx", "wJBvnM3ElmH2vAsvQCH3vajLji72bmrkstKM7SOczmiyX");

        private async void getAllButton_Click(object sender, EventArgs e)
        {

            getTimeline();
        }

        private async void searchTweets()
        {
            var tweets = await client.Search.SearchTweetsAsync("hello");
            MessageBox.Show("Tweets: " + tweets.ToString());
        }

        private async void retrieveUserName()
        {
            var user = await client.Users.GetAuthenticatedUserAsync();
            MessageBox.Show(user.ToString());
        }

        private async void getTweedById()
        {
            var tweet = await client.Tweets.GetTweetAsync(1583067836313837568);
        }

        // This program will iterate over each tweet and extract the text from the user
        private async void getTimeline()
        {
            //var timelineIterator = client.Timelines.GetUserTimelineIterator("espn");
            var userTimeline = await client.Timelines.GetUserTimelineAsync("d00229061T");

            foreach (ITweet t in userTimeline)
            {
                MessageBox.Show("Tweet Text: "+t.Text);
            }
        }

    }
}
