﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.test = "Đây là từ controascas ";
            Models.Item item = new Models.Item();
            item.getData();
            return View(item);
        }
        
    }
}