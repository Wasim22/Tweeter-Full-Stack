using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTwitter.Data.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public List<Tweet> Tweets { get; set; }
    }
}
