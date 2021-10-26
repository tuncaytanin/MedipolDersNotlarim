using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class KategoriController : Controller
    {

        KutuphaneContext db = new KutuphaneContext();
        // GET: Kategori
        public ActionResult Index()
        {
            List<Kategori> kategoriler = db.Kategori.Where(x => x.KategoriDurumu == true).ToList();
            return View(kategoriler);
        }

        // Kategori Sil

        public ActionResult Sil(int id)
        {
            Kategori ktgr = db.Kategori.Find(id);
            //ktgr.KategoriDurumu = false;
            db.Kategori.Remove(ktgr);
            db.SaveChanges();
            return RedirectToAction("index");
        }


        // Kategori Ekle

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Kategori pktgr)
        {
            Kategori ktgr = new Kategori();
            ktgr.KategoriAciklama = pktgr.KategoriAciklama;
            ktgr.KategoriAdi = pktgr.KategoriAdi;
            ktgr.KategoriDurumu = true;

            db.Kategori.Add(ktgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // Kategori Güncelle


        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Kategori ktgr = db.Kategori.Find(id);
            return View(ktgr);
        }
        [HttpPost]
        public ActionResult Guncelle(Kategori pKtgr)
        {
            Kategori ktgr = db.Kategori.Find(pKtgr.KategoriId);
            ktgr.KategoriAdi = pKtgr.KategoriAdi;
            ktgr.KategoriAciklama = pKtgr.KategoriAciklama;
            ktgr.KategoriDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}