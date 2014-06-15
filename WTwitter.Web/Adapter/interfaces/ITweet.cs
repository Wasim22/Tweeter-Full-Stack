using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTwitter.Data.Models;
using WTwitter.Web.Models;

namespace WTwitter.Web.Adapter.interfaces
{
    public interface ITweet
    {
        List<Tweet> listTweets(int id);
        void Create(Tweet tweet);
    }
}
