using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Project_III_Dr4rum.Models;

namespace Project_III_Dr4rum.Controllers
{
    public class IndexController : Controller
    {
        Dr4rumEntities1 db = new Dr4rumEntities1();
        // GET: Index
        public async Task<ActionResult> Index()
        {
            var listGroup = db.Groups.Where(a=>a.SetV==true).ToList();
            var topicTitle = (from a in db.Groups
                              from b in db.Categories
                              from c in db.Topics
                              where a.Group_Name == b.Group_Name && b.Category_Name == c.Category_Name
                               && c.setV == true
                               orderby c.Topic_Title descending
                              select c.Topic_Title).First();
            ViewBag.key = topicTitle;
            return View(listGroup);
        }
    }
}