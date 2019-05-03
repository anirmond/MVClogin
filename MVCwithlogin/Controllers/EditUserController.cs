using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithlogin.Controllers
{
    public class EditUserController : Controller
    {
        // GET: EditUser
      
       //[ValidateAntiForgeryToken]
       [Authorize]
        public ActionResult EditUser(FormCollection form)
        {
            return PartialView("_EditUser");
        }
    }
}