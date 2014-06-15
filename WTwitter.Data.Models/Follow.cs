using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTwitter.Data.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int FollowId { get; set; }
        [ForeignKey("FollowId")]
        public virtual User follow { get; set; }
    }
}