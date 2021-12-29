using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class HataSayfalariController : Controller
    {
        // GET: HataSayfalari
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hata403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Hata404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}