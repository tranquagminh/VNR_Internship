using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VNR_Internship
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Detail", "{type}/{id}",

              new { controller = "Home", action = "MonHoc", id = UrlParameter.Optional },
              new RouteValueDictionary
              {
                    {"type","KhoaHoc" }
              },
             namespaces: new[] { "Furniture.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
