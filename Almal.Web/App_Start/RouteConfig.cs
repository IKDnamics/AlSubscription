using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Almal.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Admin", action = "Admin", id = UrlParameter.Optional },
            //    namespaces: new string[] { "Almal.Web.Areas.Admin.Controllers" }
            //).DataTokens.Add("Area", "Admin");

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional },
              namespaces: new string[] { "Almal.Web.Areas.Account.Controllers" }
          ).DataTokens.Add("Area", "Account");


            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");
            //routes.MapRoute(
            // name: "Default",
            // url: "{controller}/{action}/{id}",
            // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } );


            //routes.MapRoute(
            //      name: "Default",
            //      url: "{controller}/{action}/{id}",
            //      defaults: new { controller = "Admin", action = "Admin", id = UrlParameter.Optional }
            //  );
        }
    }
}
