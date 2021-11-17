using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class PersonelController : Controller
    {

        KutuphaneContext db = new KutuphaneContext();
        // GET: Personel
        public ActionResult Index(string aranacakKelime)
        {
            List<Personel> personels = db.Personel.ToList();
            if (!string.IsNullOrEmpty(aranacakKelime))
            {
                personels = personels.Where(x => x.PersonelAdi.ToLower().Contains(aranacakKelime.ToLower()) || x.PersonelSoyadi.ToLower().Contains(aranacakKelime.ToLower())).ToList();
            }

            return View(personels);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Personel pPersonel)
        {
            pPersonel.PersonelDurumu = true;
            pPersonel.PersonelParola = ParolaOlustur(3);
            db.Personel.Add(pPersonel);

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private string ParolaOlustur(int uzunluk)
        {
            //todo parola olusturma metodunu yaz
            string sifre = "";
            while (uzunluk>0)
            {
                sifre += "a";
                uzunluk--;
            }
            return sifre;
        }

        public ActionResult Sil(int id)
        {
            Personel prs = db.Personel.Find(id);
            prs.PersonelDurumu = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Personel prs = db.Personel.Find(id);

            return View(prs);
        }


        [HttpPost]
        public ActionResult Guncelle(Personel pPersonel)
        {
            Personel prs = db.Personel.Find(pPersonel.PersonelId);
            prs.PersonelKAdi = pPersonel.PersonelKAdi;
            prs.DogumTarihi = pPersonel.DogumTarihi;
            prs.Fotograf = pPersonel.Fotograf;
            prs.PersonelEmail = pPersonel.PersonelEmail;
            prs.PersonelSoyadi = pPersonel.PersonelSoyadi;
            prs.YetkiId = pPersonel.YetkiId;
            prs.PersonelAdi = pPersonel.PersonelAdi;
            prs.Telefon = pPersonel.Telefon;
            prs.PersonelDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}