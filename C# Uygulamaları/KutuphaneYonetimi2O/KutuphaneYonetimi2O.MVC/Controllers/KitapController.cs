using KutuphaneYonetimi2O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi2O.MVC.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        KutuphaneContext db = new KutuphaneContext();
        public ActionResult Index( string aramaKelime)
        {
            var kitaplar = db.Kitap.Where(x=>x.KitapDurumu==true);
            if (!string.IsNullOrEmpty(aramaKelime))
            {
                kitaplar = kitaplar.Where(k => k.KitapAdi.Contains(aramaKelime));
            }
            return View(kitaplar.ToList());
        }

        public ActionResult Sil(int id)
        {
            Kitap ktp = db.Kitap.Find(id);
            // db.Kitap.Remove(ktp);
            ktp.KitapDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Ekle()
        {

            List<SelectListItem> kategoriler = db.Kategori.AsNoTracking().Where(x => x.KategoriDurumu == true)
                                                .Select(s => new SelectListItem
                                                {
                                                    Value = s.KategoriId.ToString(),
                                                    Text = s.KategoriAdi
                                                }).ToList();


            List<SelectListItem> yazarlar = db.Yazar.AsNoTracking().Where(x => x.YazarDurumu == true)
                                    .Select(s => new SelectListItem
                                    {
                                        Value = s.YazarId.ToString(),
                                        Text = s.YazarAdi + " " + s.YazarSoyadi
                                    }).ToList();


            List<SelectListItem> yayinEvleri = db.YayinEvi.AsNoTracking().Where(x => x.YayinEviDurumu == true)
                                    .Select(s => new SelectListItem
                                    {
                                        Value = s.YayinEviId.ToString(),
                                        Text = s.YayinEviAdi
                                    }).ToList();

            ViewBag.Kategoriler = kategoriler;
            ViewBag.YayinEvleri = yayinEvleri;
            ViewBag.Yazarlar = yazarlar;
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kitap pKitap)
        {
            pKitap.KitapDurumu = true;
            pKitap.Kategori = db.Kategori.Find(pKitap.KategoriId);
            pKitap.Yazar = db.Yazar.Find(pKitap.YazarId);
            pKitap.YayinEvi = db.YayinEvi.Find(pKitap.YayinEviId);
            db.Kitap.Add(pKitap);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Kitap kitap = db.Kitap.Find(id);


            List<SelectListItem> kategoriler = db.Kategori.AsNoTracking().Where(x => x.KategoriDurumu == true)
                                                .Select(s => new SelectListItem
                                                {
                                                    Value = s.KategoriId.ToString(),
                                                    Text = s.KategoriAdi
                                                }).ToList();


            List<SelectListItem> yazarlar = db.Yazar.AsNoTracking().Where(x => x.YazarDurumu == true)
                                    .Select(s => new SelectListItem
                                    {
                                        Value = s.YazarId.ToString(),
                                        Text = s.YazarAdi + " " + s.YazarSoyadi
                                    }).ToList();


            List<SelectListItem> yayinEvleri = db.YayinEvi.AsNoTracking().Where(x => x.YayinEviDurumu == true)
                                    .Select(s => new SelectListItem
                                    {
                                        Value = s.YayinEviId.ToString(),
                                        Text = s.YayinEviAdi
                                    }).ToList();

            ViewBag.Kategoriler = kategoriler;
            ViewBag.YayinEvleri = yayinEvleri;
            ViewBag.Yazarlar = yazarlar;

            return View(kitap);
        }
        [HttpPost]
        public ActionResult Guncelle(Kitap pKitap)
        {

            Kitap ktp = db.Kitap.Find(pKitap.KitapId);
            ktp.KitapDurumu = true;
            ktp.Kategori = db.Kategori.Find(pKitap.KategoriId);
            ktp.Yazar = db.Yazar.Find(pKitap.YazarId);
            ktp.YayinEvi = db.YayinEvi.Find(pKitap.YayinEviId);
            ktp.KitapAdi = pKitap.KitapAdi;
            ktp.KitapAciklama = pKitap.KitapAciklama;
            ktp.SayfaSayisi = pKitap.SayfaSayisi;
            
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}