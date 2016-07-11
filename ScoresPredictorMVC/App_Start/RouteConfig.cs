using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ScoresPredictorMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Fixtures/View
            //routes.MapRoute(
            //    name: "Fixtures",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "Fixtures", action = "View" }
            //);

            routes.MapRoute("About",
                "About",
                new { controller = "Home", action = "About" }
            );

            routes.MapRoute("Fixtures",
                "Fixtures",
                new { controller = "Fixtures", action = "View" }
            );

            routes.MapRoute("View",
                "View",
                new { controller = "Fixtures", action = "View" }
            );

            routes.MapRoute("Edit",
                "Edit",
                new { controller = "Fixtures", action = "Edit" }
            );

            routes.MapRoute("Enter",
                "Enter",
                new { controller = "Fixtures", action = "Enter", id = "1" }
            );

            routes.MapRoute("EnterId",
                "Enter/{id}",
                new { controller = "Fixtures", action = "Enter", id =  UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}