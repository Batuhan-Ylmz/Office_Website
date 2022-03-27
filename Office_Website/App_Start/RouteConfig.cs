using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Office_Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Home",
               url: "Anasayfa",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "About",
               url: "Hakkimizda",
               defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Topic",
               url: "Calisma-Alanlarimiz",
               defaults: new { controller = "Topic", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Blog",
               url: "Bloglarimiz",
               defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Contact",
               url: "Iletisim",
               defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
