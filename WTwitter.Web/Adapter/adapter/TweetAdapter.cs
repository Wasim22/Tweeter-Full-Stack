using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTwitter.Data;
using WTwitter.Data.Models;
using WTwitter.Web.Adapter.interfaces;
using WTwitter.Web.Models;

namespace WTwitter.Web.Adapter.adapter
{
    public class TweetAdapter : ITweet
    {
        public List<Tweet> listTweets(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Tweet> tweets = db.Tweets.Where(t => t.UserId == id).ToList();
            List<UserTweetVM> follows = db.Follows.Where(f => f.UserId == id).Select(f => new UserTweetVM
            {
                Tweets = db.Tweets.Where(t => t.UserId == f.follow.Id).ToList()
            }).ToList();

            foreach (UserTweetVM user in follows)
            {
                foreach (Tweet tweet in user.Tweets)
                {
                    tweets.Add(tweet);
                }
            }

            return tweets;
        }

        public void Create(Tweet tweet)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Tweets.Add(tweet);
            db.SaveChanges();
        }
    }
}