using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.Repository;

namespace Blog.WebMvc.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager am = new AboutManager(new AboutRepository());

        // GET: About
        public ActionResult Index()
        {
            var hakkimda = am.GetFirstOrDefaultAbout();
            return View(hakkimda);
        }
    }
}