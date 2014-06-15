using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WTwitter.Data.Models;
using WTwitter.Web.Adapter.adapter;
using WTwitter.Web.Adapter.interfaces;

namespace WTwitter.Web.Controllers
{
    public class apiUserController : ApiController
    {
        private IUser _adapter;
        public apiUserController()
        {
            _adapter = new UserAdapter();
        }

        public IHttpActionResult Get(int id = -1)
        {
            if (id != -1)
            {
                return Ok(_adapter.getUser(id));
            }
            else
            {
                return Ok(_adapter.listUsers());
            }
        }

        public IHttpActionResult Post(User user)
        {
            _adapter.Create(user);
            return Ok();
        }
    }
}