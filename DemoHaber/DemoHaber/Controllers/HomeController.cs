using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoHaber.Models;
using PagedList;
using PagedList.Mvc;
namespace DemoHaber.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult HaberListele(String p , int sayfa = 1)
        {
            var degerler = from x in c.Habers select x;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(y => y.HaberBaslik.Contains(p));
            }
            var listele = degerler.OrderByDescending(x => x.HaberEklenmeTarihi).Where(x => x.HaberEklenmeTarihi <= DateTime.Today).ToList().ToPagedList(sayfa,3);
            return View(listele);
        }
        public ActionResult HaberSayfa(int id)
        {
            var degerler = c.Habers.Where(x => x.HaberId == id).ToList();
            return View(degerler);
        }
        public ActionResult KategoriGetir(int id , int sayfa = 1)
        {
            var kategoris = c.Habers.OrderByDescending(x => x.HaberEklenmeTarihi).Where(x => x.Kategori.KategoriId == id).ToList().ToPagedList(sayfa,5);
            return View(kategoris);
        }
        public ActionResult YeniEklenen(String p , int sayfa = 1)
        {
            var degerler = from x in c.Habers select x;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(y => y.HaberBaslik.Contains(p));
            }
            var listele = degerler.OrderByDescending(x => x.HaberEklenmeTarihi).Where(x => x.HaberEklenmeTarihi <= DateTime.Today).ToList().ToPagedList(sayfa,5);
            return View(listele);
        }
        public ActionResult Yorumlanan(String p , int sayfa = 1)
        {
            var degerler = from x in c.Habers select x;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(y => y.HaberBaslik.Contains(p));
            }
            var listele = degerler.OrderByDescending(x => x.Yorums.Count()).ToList().ToPagedList(sayfa,5);
            return View(listele);

        }
    }
}