using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBanHangOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Contact",
                url: "lien-he/{Alias}",
                defaults: new { controller = "Contact", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "ShoppingCart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Products",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products", action = "ProductCategory", alias = UrlParameter.Optional, id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }

            );
            routes.MapRoute(
               name: "detailProduct",
               url: "chi-tiet/{alias}-p{id}",
               defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional, id = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }

           );
            routes.MapRoute(
                name: "CategoryProduct",
                url: "san-pham/{Alias}",
                defaults: new { controller = "Products", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }

            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            
            );

        }
    }
}
