﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class AdvController : Controller
    {
        // GET: Admin/Adv
        public ActionResult Index()
        {
            return View();
        }
    }
}