using KutuphaneYonetimi1O.Entites.Model;
using KutuphaneYonetimi1O.MVC.Models;
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
            var kitaplar = Login.Kitaps.Where(x => x.KitapDurumu == true || x.KitapDurumu == false);
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

            List<SelectListItem> kategoriler =Login.Kategoris.Where(x=>x.KategoriDurumu==true)
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
            ktp.Yazar = db.Yazar.Find(pKitap.Yazar.YazarId);
            db.SaveChanges();

            for (int i = 0; i < Login.Kitaps.Count; i++)
            {
                if (Login.Kitaps[i].KitapId == ktp.KitapId)
                {
                    Login.Kitaps[i].KitapDurumu = true;
                    break;
                }
            }

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
            pKitap.KitapDurumu = true;
            db.Kitap.Add(pKitap);
            db.SaveChanges();

            Login.Kitaps.Add(pKitap);
            Login.KitabiEslemeYap();

            return RedirectToAction("Index");
        }

    }
}