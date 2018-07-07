using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_III_Dr4rum.Models;

namespace Project_III_Dr4rum.Controllers
{
    public class IndexController : Controller
    {
        Dr4rumEntities db = new Dr4rumEntities();
        // GET: Index
        public ActionResult Index()
        {
            var listGroup = db.Groups.ToList();
            return View(listGroup);
        }


    }
}