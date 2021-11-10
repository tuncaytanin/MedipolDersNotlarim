using KutuphaneYonetimi2O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList;
using PagedList.Mvc;



namespace KutuphaneYonetimi2O.MVC.Controllers
{
    public class UyeController : Controller
    {


        KutuphaneContext db = new KutuphaneContext();
        // GET: Uye
        public ActionResult Index(string uyeAdi, int sayfa=2)
        {
            var uyeler = db.Uye.Where(x => x.UyeDurumu == true);
            if (!string.IsNullOrEmpty(uyeAdi))
            {
              uyeler.Where(x => x.UyeAdi.Contains(uyeAdi));
            }
         
            return View(uyeler.ToList().ToPagedList(sayfa, 2));


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
            uye.Telefon = pUye.Telefon;
            uye.Cinsiyet = pUye.Cinsiyet;
            uye.DogumTarihi = pUye.DogumTarihi;
            uye.UyeAdi = pUye.UyeAdi;
            uye.UyeSoyadi = pUye.UyeSoyadi;
            uye.UyeEmail = pUye.UyeEmail;
            uye.Fotograf = pUye.Fotograf;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}