using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTwitter.Data;
using WTwitter.Data.Models;
using WTwitter.Web.Adapter.interfaces;

namespace WTwitter.Web.Adapter.adapter
{
    public class UserAdapter : IUser
    {
        public List<User> listUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<User> Users = db.Users.ToList();
            return Users;
        }

        public User getUser(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            User user = db.Users.Where(u => u.Id == id).FirstOrDefault();
            return user;
        }

        public void Create(User user)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User Verify(VMLogin vmlogin)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            User user = db.Users.Where(u => u.Username == vmlogin.Username && u.Password == vmlogin.Password).FirstOrDefault();
            return user;
        }

        public void Follow(Follow follow)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Follows.Add(follow);
            db.SaveChanges();
        }
    }
}