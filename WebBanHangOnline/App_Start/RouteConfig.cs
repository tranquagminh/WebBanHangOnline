﻿using System;
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
                name: "News",
                url: "tin-tuc",
                defaults: new { controller = "News", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "DetailNews",
                url: "tin-tuc/{alias}-n{id}",
                defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional, alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut" },
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
                url: "san-pham/{alias}",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }

            );
            routes.MapRoute(
                name: "BaiViet",
                url: "post/{Alias}",
                defaults: new { controller = "Artical", action = "Index", Alias = UrlParameter.Optional },
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
