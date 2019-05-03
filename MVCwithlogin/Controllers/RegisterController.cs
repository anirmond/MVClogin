using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithlogin.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
       
        public ActionResult Register(RegisterUser user)
        {

            UserUtil userUtil = new UserUtil();
            if (ModelState.IsValid)
            {
                userUtil.RegisterNewUser(user);
                ModelState.Clear();
                return View();
            }

            return View();
        }
    }
}