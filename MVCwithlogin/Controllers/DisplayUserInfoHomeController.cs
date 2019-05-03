using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithlogin.Controllers
{
    public class DisplayUserInfoHomeController : Controller
    {
        // GET: DisplayUserInfoHome
        public ActionResult DisplayUserInfoHome()
        {
            return View();
        }
    }
}