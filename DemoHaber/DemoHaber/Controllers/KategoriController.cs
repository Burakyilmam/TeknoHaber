using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoHaber.Models;

namespace DemoHaber.Controllers
{
    public class KategoriController : Controller
    {
        Context c = new Context();
        [Authorize]
        public ActionResult Listele()
        {
            var kategoriler = c.Kategoris.ToList();
            return View(kategoriler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Ekle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
        public ActionResult Sil(int id)
        {
            var kategoriSil = c.Kategoris.Find(id);
            c.Kategoris.Remove(kategoriSil);
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
        [Authorize]
        public ActionResult Getir(int id)
        {
            var kategoriGetir = c.Kategoris.Find(id);
            return View("Getir",kategoriGetir);
        }
        public ActionResult Guncelle(Kategori k)
        {
            var kategoriGuncelle = c.Kategoris.Find(k.KategoriId);
            kategoriGuncelle.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}