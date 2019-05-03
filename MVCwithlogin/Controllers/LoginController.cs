using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Model;
using System.Web.Security;
using System.Text.RegularExpressions;

namespace MVCwithlogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
       [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View("Login");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form)
        {
            UserUtil userUtil = new UserUtil();
           LoggedInUser user =userUtil.AuthenticateUser(form["txtUserName"].ToString(), form["txtPassword"].ToString());
            if (user != null)
            {

                if (user.UserName != null && user.IsMatched == true)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    ViewData["LoggedinUser"] = user.FirstNAme.ToString()+ " " + user.LastName.ToString();
                    TempData["singleuser"] = user.UserName;

                    var url = HttpContext.Request.UrlReferrer.Query.ToString();
                    if (!string.IsNullOrEmpty(url))
                    {
                        Regex.Replace(url, @"\s+", "");

                        var uri = url.Split(new char[] { '%', '2', 'f' }, StringSplitOptions.RemoveEmptyEntries);
                        var actionName = uri[1];
                        var controllerName = uri[2];
                        return RedirectToAction(actionName, controllerName);
                    }
                    else
                    {
                        return View("WelcomeUser", user);

                    }
                }
                else
                {
                    ViewData["password"] = "Please Give Correct Password";
                    ViewData["txtUsername"] = user.UserName.ToString();
                    return View();
                }
            }
            else
            {
                ViewData["username"] = "Please create a new Account";
                return View();

            }
            

           
        }
    }
}