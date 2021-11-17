using KutuphaneYonetimi2O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi2O.MVC.Controllers
{
    public class YetkiController : Controller
    {
        KutuphaneContext db = new KutuphaneContext();
        // GET: Yetki
        public ActionResult Index()
        {
            List<Yetki> yetkis = db.Yetki.ToList();
            return View(yetkis);
        }


        [HttpPost]
        public ActionResult Ekle(Yetki pYetki)
        {
            //Yetki yetki = db.Yetki.Find(pYetki.YetkiId);

            //yetki.YetkiAdi = pYetki.YetkiAdi;
            //yetki.YetkiDurumu = true;
            //yetki.YetkiAciklama = pYetki.YetkiAciklama;
            pYetki.YetkiDurumu = true;
            db.Yetki.Add(pYetki);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}