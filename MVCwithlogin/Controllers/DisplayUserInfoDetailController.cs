
using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MVCwithlogin.Controllers
{
    public class DisplayUserInfoDetailController : Controller
    {
        // GET: DisplayUserInfo


       [Authorize]
        public ActionResult DisplayUserInfoDetail()
        {
            UserUtil user = new UserUtil();
            List<UserDisplayGrid> userinfo = user.GridDisplayUser();

            return View(userinfo);
        }
    }
}