using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WTwitter.Web.Adapter.adapter;
using WTwitter.Web.Adapter.interfaces;
using WTwitter.Data.Models;

namespace WTwitter.Web.Controllers
{
    public class apiLoginController : ApiController
    {
        private IUser _adapter;
        public apiLoginController()
        {
            _adapter = new UserAdapter();
        }

        public IHttpActionResult Post(VMLogin vmlogin)
        {
            User user = _adapter.Verify(vmlogin);
            if ( user == null)
            {
                return Unauthorized();
            }
            else
            return Ok(user);
        }

    }
}