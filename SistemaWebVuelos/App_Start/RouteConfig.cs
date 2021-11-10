using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaWebVuelos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vuelo", action = "Edit" }
            );

            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vuelo", action = "Delete" }
            );

            routes.MapRoute(
                name: "Detail",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vuelo", action = "Detail" }
            );

            routes.MapRoute(
                name: "IndexPorDestino",
                url: "{controller}/{action}/{destino}",
                defaults: new { controller = "Vuelo", action = "IndexPorDestino"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
