using KutuphaneYonetimi1O.Entites.Model;
using KutuphaneYonetimi1O.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class KitapHareketController : Controller
    {
       
        // GET: KitapHareket
        public ActionResult Index()
        {
            List<KitapHareket> kitapHarekets;
            using (KutuphaneContext db = new KutuphaneContext())
            {
                kitapHarekets = db.KitapHareket.AsNoTracking().Where(x => x.KitapHareketDurumu == true).ToList();
            }

            for (int i = 0; i < kitapHarekets.Count; i++)
            {
                kitapHarekets[i].Kitap = Login.Kitaps.Where(x => x.KitapId == kitapHarekets[i].KitapId).FirstOrDefault();
                kitapHarekets[i].Uye = Login.Uyes.Where(x => x.UyeId == kitapHarekets[i].UyeId).FirstOrDefault();
            }
            
            return View(kitapHarekets);
        }

        [HttpGet]
        public ActionResult OduncVer(int? id)
        {
            List<SelectListItem> kitaplar = Login.Kitaps.Where(x => x.KitapDurumu == true)
                                            .Select(s => new SelectListItem
                                            {
                                                Value = s.KitapId.ToString(),
                                                Text = s.KitapAdi
                                            }).ToList();

            List<SelectListItem> uyeler = Login.Uyes.Where(x => x.UyeDurumu == true)
                                           .Select(s=> new SelectListItem
                                           {
                                               Value = s.UyeId.ToString(),
                                               Text = s.UyeAdi+ " " + s.UyeSoyadi
                                           }
                                            ).ToList();

            List<SelectListItem> personeller = Login.Personels.Where(x => x.PersonelDurumu == true)
                    .Select(s => new SelectListItem
                    {
                        Value = s.PersonelId.ToString(),
                        Text = s.PersonelAdi+" " + s.PersonelSoyadi
                    }).ToList();

            ViewBag.Kitaplar = kitaplar;
            ViewBag.Uyeler = uyeler;
            ViewBag.Personeller = personeller;

            return View();
        }
    
        [HttpPost]
        public ActionResult OduncVer(KitapHareket pKitapHareket)
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                KitapHareket ktpHrkt= new KitapHareket();
                ktpHrkt.Kitap = Login.Kitaps.Where(x => x.KitapId == pKitapHareket.KitapId).FirstOrDefault();
                ktpHrkt.AlmaTarihi = DateTime.Now;
                ktpHrkt.IadeTarihi = DateTime.Now.AddDays(7);
                ktpHrkt.KitapHareketDurumu = true;
                ktpHrkt.Personel = Login.Personels.Where(x => x.PersonelId == pKitapHareket.PersonelId).FirstOrDefault();
                ktpHrkt.Uye = Login.Uyes.Where(x=>x.UyeId == pKitapHareket.UyeId).FirstOrDefault();
                db.KitapHareket.Add(ktpHrkt);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}