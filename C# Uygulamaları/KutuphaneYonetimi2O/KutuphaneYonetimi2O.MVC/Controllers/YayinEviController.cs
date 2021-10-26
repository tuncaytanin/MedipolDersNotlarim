using KutuphaneYonetimi2O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi2O.MVC.Controllers
{
    public class YayinEviController : Controller
    {
        KutuphaneContext db = new KutuphaneContext();
        // GET: YayinEvi
        public ActionResult Index()
        {
            List<YayinEvi> yayinEvleri = db.YayinEvi.AsNoTracking().Where(x => x.YayinEviDurumu == true).ToList();
            return View(yayinEvleri);
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
            db.SaveChanges();

            return RedirectToAction("Index");
        }




        public ActionResult Sil(int id)
        {
            YayinEvi yayinEvi = db.YayinEvi.Find(id);
            yayinEvi.YayinEviDurumu = false;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}