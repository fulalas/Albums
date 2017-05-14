﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Albums.web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Photo",
                url: "Photo/Index/{albumId}/{id}",
                defaults: new { controller = "Photo", action = "Index", albumId = UrlParameter.Optional, id = UrlParameter.Optional }
        );
        }
    }
}