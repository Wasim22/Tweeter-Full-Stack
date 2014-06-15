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
    public class apiFollowController : ApiController
    {
        private IUser _adapter;

        public apiFollowController()
        {
            _adapter = new UserAdapter();
        }

        public IHttpActionResult Post(Follow follow)
        {
            _adapter.Follow(follow);
            return Ok();
        }
    }
}