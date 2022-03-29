using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebMvc.Controllers
{
    public class SubscripeController : Controller
    {
        // GET: Subscripe
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HaberBulteni()
        {
            return PartialView();
        }
    }
}