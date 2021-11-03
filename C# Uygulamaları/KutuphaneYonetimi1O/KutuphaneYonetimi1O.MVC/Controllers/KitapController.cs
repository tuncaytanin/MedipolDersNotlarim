using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class KitapController : Controller
    {


        KutuphaneContext db = new KutuphaneContext();

        // GET: Kitap

        public ActionResult Index(string aranacakKelime)
        {
            var kitaplar = db.Kitap.Where(x => x.KitapDurumu == true);
            if (!string.IsNullOrEmpty(aranacakKelime))
            {
                kitaplar = kitaplar.Where(x => x.KitapAdi.Contains(aranacakKelime));
            }
           

            return View(kitaplar.ToList());
        }


        public ActionResult Sil(int id)
        {
            Kitap ktp = db.Kitap.Find(id);
            ktp.KitapDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Kitap ktp = db.Kitap.Find(id);

            List<SelectListItem> yazarlar = db.Yazar.AsNoTracking().Where(y => y.YazarDurumu == true)
                                .Select(s => new SelectListItem
                                {
                                    Value = s.YazarId.ToString(),
                                    Text = s.YazarAdi + " " + s.YazarSoyadi
                                }).ToList();


            List<SelectListItem> yayinEvleri = db.YayinEvi.AsNoTracking().Where(y => y.YayinEviDurumu == true)
                                            .Select(s => new SelectListItem
                                            {
                                                Value = s.YayinEviId.ToString(),
                                                Text = s.YayinEviAdi
                                            }).ToList();

            List<SelectListItem> kategoriler = db.Kategori.AsNoTracking().Where(x => x.KategoriDurumu == true)
                .Select(s => new SelectListItem
                {
                    Value = s.KategoriId.ToString(),
                    Text = s.KategoriAdi
                }).ToList();
            ViewBag.Kategoriler = kategoriler;
            ViewBag.Yazarlar = yazarlar;
            ViewBag.YayinEvleri = yayinEvleri;
            return View(ktp);
        }

        [HttpPost]
        public ActionResult Guncelle(Kitap pKitap)
        {
            Kitap ktp = db.Kitap.Find(pKitap.KitapId);
            ktp.KitapAdi = pKitap.KitapAdi;
            ktp.KitapAciklama = pKitap.KitapAciklama;
            ktp.Kategori = db.Kategori.Find(pKitap.Kategori.KategoriId);
            ktp.YayinEvi = db.YayinEvi.Find(pKitap.YayinEvi.YayinEviId);
            ktp.Yazar= db.Yazar.Find(pKitap.Yazar.YazarId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet] // Sayfa yüklendiğinde çalışacak

        public  ActionResult Ekle()
        {

            List<SelectListItem> yazarlar = db.Yazar.AsNoTracking().Where(y => y.YazarDurumu == true)
                                            .Select(s => new SelectListItem
                                            {
                                                Value = s.YazarId.ToString(),
                                                Text = s.YazarAdi + " " + s.YazarSoyadi
                                            }).ToList();


            List<SelectListItem> yayinEvleri = db.YayinEvi.AsNoTracking().Where(y => y.YayinEviDurumu == true)
                                            .Select(s => new SelectListItem
                                            {
                                                Value = s.YayinEviId.ToString(),
                                                Text = s.YayinEviAdi
                                            }).ToList();

            List<SelectListItem> kategoriler = db.Kategori.AsNoTracking().Where(x => x.KategoriDurumu == true)
                .Select(s => new SelectListItem
                {
                    Value = s.KategoriId.ToString(),
                    Text = s.KategoriAdi
                }).ToList();

            ViewBag.Kategoriler = kategoriler;
            ViewBag.Yazarlar = yazarlar;
            ViewBag.YayinEvleri = yayinEvleri;
            return View();
        }

        [HttpPost] // Sayfa içerisinde bir yerde sayfayı post edildiğinde çalışacak
        public ActionResult Ekle(Kitap pKitap)
        {
            pKitap.Kategori = db.Kategori.Find(pKitap.KategoriId);
            pKitap.Yazar = db.Yazar.Find(pKitap.YazarId);
            pKitap.YayinEvi = db.YayinEvi.Find(pKitap.YayinEviId);
            pKitap.KitapDurumu = true;
            db.Kitap.Add(pKitap);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}