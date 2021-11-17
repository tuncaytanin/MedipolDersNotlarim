using KutuphaneYonetimi2O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi2O.MVC.Controllers
{
    public class PersonelController : Controller
    {
        KutuphaneContext db = new KutuphaneContext();
        // GET: Personel
        public ActionResult Index()
        {
            List<Personel> personels =  db.Personel.Where(x => x.PersonelDurumu == true).ToList();
            return View(personels);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }


        public ActionResult Sil(int id)
        {

            Personel prs = db.Personel.Find(id);
            prs.PersonelDurumu = false;
            db.SaveChanges();

            return RedirectToAction("Index");
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
            prs.PersonelAdi = pPersonel.PersonelAdi;
            prs.PersonelEmail = pPersonel.PersonelEmail;
            prs.PersonelKAdi = pPersonel.PersonelKAdi;
            prs.PersonelSoyadi = pPersonel.PersonelSoyadi;
            prs.YetkiId = pPersonel.YetkiId;
            prs.Fotograf = pPersonel.Fotograf;
            prs.DogumTarihi = pPersonel.DogumTarihi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        private string ParolaOlustur(int uzunluk)
        {
            string parola = "";
            for (int i = 0; i < uzunluk; i++)
            {
                parola += "a";
            }
            return parola;
        }
    }
}