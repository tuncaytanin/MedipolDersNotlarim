using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class YayinEviController : Controller
    {

        KutuphaneContext db = new KutuphaneContext();
        // GET: YayinEvi
        public ActionResult Index()
        {
            List<YayinEvi> yayinevleri = db.YayinEvi.ToList();

            return View(yayinevleri);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(YayinEvi pYayinEvi)
        {
            pYayinEvi.YayinEviDurumu = true;
            db.YayinEvi.Add(pYayinEvi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            YayinEvi yayinEvi =  db.YayinEvi.Find(id);

            yayinEvi.YayinEviDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");
            //db.YayinEvi.Remove(yayinEvi) ;
        }

        [HttpGet]

        public ActionResult Guncelle(int id)
        {
            YayinEvi yayinEvi = db.YayinEvi.Find(id);
            return View(yayinEvi);

        }
        [HttpPost]

        public ActionResult Guncelle(YayinEvi pYayinEvi)
        {
            YayinEvi yayinEvi = db.YayinEvi.Find(pYayinEvi.YayinEviId);
            yayinEvi.YayinEviAdi = pYayinEvi.YayinEviAdi;
            yayinEvi.YayinEviAciklama = pYayinEvi.YayinEviAciklama;

            yayinEvi.YayinEviDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}