using DemoHaber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoHaber.Controllers
{
    public class YorumController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Yorum y)
        {
            c.Yorums.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public PartialViewResult ListComment(int id)
        {
            var yorumlar = c.Yorums.Where(x => x.Haber.HaberId == id).ToList();
            return PartialView(yorumlar);
        }
    }
}