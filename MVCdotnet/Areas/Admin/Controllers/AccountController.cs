using MVCdotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCdotnet.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User model)
        {
            if (model.UserName == "sneha" && model.Password == "sneha")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "At");
            }
            return View();
        }
    }
}