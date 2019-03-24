using System;
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
            ViewBag.abc = "kcskcskdc";
            Models.Item item = new Models.Item();
            item.getData();
            return View(item);
        }
        
    }
}