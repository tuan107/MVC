using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
namespace MVCTest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? page)
        {
            int trangtrang = (page ?? 1); ;
            

            List<Models.Item> l = new List<Models.Item>();

            l = DAL.DALItem.getSp();

            IEnumerable<Models.Item> it = l.OrderBy(n=>n.Id); // sắp xếp theo id


            return View(it.ToPagedList(trangtrang,4));
        }
        public ActionResult Index2(int? page)
        {
            int trangtrang = (page ?? 1); ;


            List<Models.Item> l = new List<Models.Item>();
            l = DAL.DALItem.getSp();
            IEnumerable<Models.Item> it = l.OrderBy(n => n.Id);


            return View(l);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Item it)
        {
            DAL.DALItem.insert(it);


            return View();
        }
        public ActionResult Edit(int id)
        {

            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Item it,int id)
        {
            it.Id = id;
            DAL.DALItem.update(it);

            return View(it);
        }


    }
}