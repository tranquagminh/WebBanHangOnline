using System;
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
        public ActionResult Index(int? id)
        {
            var items = db.Products.ToList();
            if(id != null)
            {
                items = items.Where(x => x.Id == id).ToList();   
            }
            return View(items);
        }
        public ActionResult Detail(string alias,int id)
        {
            var item = db.Products.Find(id);
            if(item != null)
            {
                db.Products.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                db.Entry(item).Property(x => x.ViewCount).IsModified = true;
                db.SaveChanges();
            }
            return View(item);
        }
        public ActionResult ProductCategory(string alias,int id)
        {
            var items = db.Products.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryID == id).ToList();
            }
            var cate = db.ProductCategories.Find(id);
            if(cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateID = id;
            return View(items);
        }
        public ActionResult ListProduct()
        {
            var items = db.Products.Where(x => x.isHome && x.IsActive).Take(12).ToList();
            return PartialView("_ListProduct", items);
        }
    }
}