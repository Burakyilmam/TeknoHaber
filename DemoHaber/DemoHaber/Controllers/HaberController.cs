using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoHaber.Models;

namespace DemoHaber.Controllers
{
    public class HaberController : Controller
    {
        Context c = new Context();
        [Authorize]
        public ActionResult Listele()
        {
            var haberler = c.Habers.ToList();
            return View(haberler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Ekle()
        {
            List<SelectListItem> deger = (from x in c.Kategoris.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.KategoriAd,
                                              Value = x.KategoriId.ToString()
                                          }).ToList();
            ViewBag.dgr = deger;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Ekle(Haber h)
        {
            var kategori = c.Kategoris.Where(m => m.KategoriId == h.Kategori.KategoriId).FirstOrDefault();
            h.Kategori = kategori;
            h.HaberEklenmeTarihi = DateTime.Today;
            c.Habers.Add(h);
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
        public ActionResult Sil(int id)
        {
            var HaberSil = c.Habers.Find(id);
            c.Habers.Remove(HaberSil);
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
        [Authorize]
        public ActionResult Getir(int id)
        {
            var HaberGetir = c.Habers.Find(id);
            return View("Getir", HaberGetir);
        }
        public ActionResult Guncelle(Haber h)
        {
            var HaberGuncelle = c.Habers.Find(h.HaberId);
            HaberGuncelle.HaberBaslik = h.HaberBaslik;
            HaberGuncelle.HaberKapakFoto = h.HaberKapakFoto;
            HaberGuncelle.HaberYazi = h.HaberYazi;
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}