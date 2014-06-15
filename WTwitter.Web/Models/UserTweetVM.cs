using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTwitter.Data.Models;

namespace WTwitter.Web.Models
{
    public class UserTweetVM
    {
        public List<Tweet> Tweets { get; set; }
    }
}