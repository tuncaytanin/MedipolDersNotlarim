using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class YazarController : Controller
    {

        KutuphaneContext db = new KutuphaneContext();
        // GET: Yazar
        public ActionResult Index()
        {
            List<Yazar> yazarlar = db.Yazar.AsNoTracking().Where(x => x.YazarDurumu == true).ToList();
            return View(yazarlar);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Yazar pYazar)
        {
            pYazar.YazarDurumu = true;
            db.Yazar.Add(pYazar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Yazar yazar = db.Yazar.Find(id);
            yazar.YazarDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Guncelle( int id)
        {
            Yazar yazar = db.Yazar.Find(id);
            return View(yazar);
        }

        [HttpPost]
        public ActionResult Guncelle(Yazar pYazar)
        {
            Yazar yazar = db.Yazar.Find(pYazar.YazarId);
            yazar.YazarDurumu = true;
            yazar.YazarAdi = pYazar.YazarAdi;
            yazar.YazarSoyadi = pYazar.YazarSoyadi;
            yazar.DogumTarihi = pYazar.DogumTarihi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarinKitaplari(int id)
        {
            List<Kitap> kitaplar = db.Kitap.AsNoTracking().Where(x=>x.YazarId==id ).ToList();

            return View(kitaplar);
        }

    }
}