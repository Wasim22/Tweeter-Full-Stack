using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTwitter.Data.Models;

namespace WTwitter.Web.Adapter.interfaces
{
    public interface IUser
    {
        List<User> listUsers();
        User getUser(int id);
        void Create(User user);
        User Verify(VMLogin login);
        void Follow(Follow follow);
        //Follow listFollows(int id);
    }
}
