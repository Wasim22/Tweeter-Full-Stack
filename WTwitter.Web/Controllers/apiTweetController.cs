using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WTwitter.Data.Models;
using WTwitter.Web.Adapter.adapter;
using WTwitter.Web.Adapter.interfaces;
using WTwitter.Web.Models;

namespace WTwitter.Web.Controllers
{
    public class apiTweetController : ApiController
    {
        private ITweet _adapter;

        public apiTweetController()
        {
            _adapter = new TweetAdapter();
        }

        public IHttpActionResult Get(int id)
        {
            List<Tweet> List = _adapter.listTweets(id);
            return Ok(List);
        }

        public IHttpActionResult Post(Tweet tweet)
        {
            _adapter.Create(tweet);
            return Ok();
        }
    }
}