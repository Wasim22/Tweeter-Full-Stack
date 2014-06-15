using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTwitter.Data.Models;

namespace WTwitter.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>{
        public ApplicationDbContext(): base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Follow> Follows { get; set; }
    }    
}
