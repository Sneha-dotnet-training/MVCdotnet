using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdotnet.Filters
{
    public class SnehaAction : ActionFilterAttribute, IActionFilter, IResultFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello");
            filterContext.Controller.ViewBag.Message = " Action filter is implemented";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hii");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);


        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}