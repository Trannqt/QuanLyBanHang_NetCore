using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (HttpContext.Session.GetString("ID_SESSION") == null)
            {
                context.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
            else
            {
                if (HttpContext.Session.GetInt32("CREDENTITY_SESSION") == 2)
                {
                    context.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "TrangChu", action = "Index" }));
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
