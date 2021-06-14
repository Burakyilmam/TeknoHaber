using DemoHaber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoHaber.Controllers
{
    public class GirişController : Controller
    {
        Context c = new Context();
        [Authorize]
        public ActionResult AdminPanel()
        {
            var admin = (string)Session["AdminAd"];
            var degerler = c.Admins.FirstOrDefault(x=>x.AdminAd == admin);
            ViewBag.a = admin;
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.AdminAd == a.AdminAd && x.AdminSifre == a.AdminSifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdminAd,false);
                Session["AdminAd"] = bilgiler.AdminAd.ToString();
                return RedirectToAction("AdminPanel");
            }
            else
            {
                return View();
            }  
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}