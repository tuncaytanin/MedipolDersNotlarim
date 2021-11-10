using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class UyeController : Controller
    {
        KutuphaneContext db = new KutuphaneContext();
        // GET: Uye

       
        public ActionResult Index(string uyeAdi, int page=1)
        {
            var uyeler = db.Uye.AsNoTracking().Where(x=>x.UyeDurumu == true || x.UyeDurumu==false);
            if (!string.IsNullOrEmpty(uyeAdi))
            {
                uyeler = uyeler.Where(x => x.UyeAdi.Contains(uyeAdi) || x.UyeSoyadi.Contains(uyeAdi));
            }


            return View(uyeler.ToList().ToPagedList(page, 3));
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Uye pUye)
        {
            pUye.UyeDurumu = true;
            db.Uye.Add(pUye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Sil(int id)
        {
            Uye uye = db.Uye.Find(id);
            uye.UyeDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Uye uye = db.Uye.Find(id);
            return View(uye);
        }
        [HttpPost]
        public ActionResult Guncelle(Uye pUye)
        {
            Uye uye = db.Uye.Find(pUye.UyeId);
            uye.UyeAdi = pUye.UyeAdi;
            uye.UyeSoyadi = pUye.UyeSoyadi;
            uye.Cinsiyet = pUye.Cinsiyet;
            uye.DogumTarihi = pUye.DogumTarihi;
            uye.Telefon = pUye.Telefon;
            uye.UyeEmail = pUye.UyeEmail;
            uye.Fotograf = pUye.Fotograf;
            uye.UyeDurumu = true;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}