using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdotnet.Filters;

namespace MVCdotnet.Areas.Admin.Controllers
{
    public class AtController : Controller
    {
        // GET: Admin/At
        [SnehaAutho]
        [SnehaAction]
        [SnehaException]
        
        public ActionResult Index()
        {
            return View();
        }
    }
}