﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuProduct()
        {
            var items = db.Products.Where(x => x.isHome && x.IsActive).Take(12).ToList();
            return PartialView("_MenuProduct", items);
        }
    }
}