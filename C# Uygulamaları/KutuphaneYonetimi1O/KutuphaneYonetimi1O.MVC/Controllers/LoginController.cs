using KutuphaneYonetimi1O.Entites.Model;
using KutuphaneYonetimi1O.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
    
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Personel pPersonel)
        {
            pPersonel.PersonelKAdi = pPersonel.PersonelEmail;
            using (KutuphaneContext db = new KutuphaneContext())
            {
               Personel personel =   db.Personel.AsNoTracking().Where(x => (x.PersonelEmail == pPersonel.PersonelEmail || x.PersonelKAdi == pPersonel.PersonelKAdi) && x.PersonelParola == pPersonel.PersonelParola).FirstOrDefault();


                if (personel !=null)
                {
                    FormsAuthentication.SetAuthCookie(personel.PersonelKAdi, false);
                    // Sisteme login olunuldu demektir.
                    Session["PersonelId"] = personel.PersonelId;
                    Session["Personeli"] = personel.PersonelAdi + " " + personel.PersonelSoyadi;
                    Session["PersonelEmail"] = personel.PersonelEmail;
                    Session["YetkiId"] = personel.YetkiId;
                    Login.Personel = personel;
                    Login.Personel.PersonelParola = "";
                    return RedirectToAction("Index", "Kategori");

                }
            }

            return RedirectToAction("Index");
        }


        public ActionResult CikisYap()
        {
            Session.Clear();
            Login.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}