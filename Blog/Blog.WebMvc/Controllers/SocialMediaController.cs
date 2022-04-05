using Blog.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Concrate;

namespace Blog.WebMvc.Controllers
{
    public class SocialMediaController : Controller
    {
        private SocialMediaManager sm = new SocialMediaManager(new EfSocialMediaRepository());
        // GET: SocialMedia
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult SocialMediaInfo()
        {
            var socialMedias = sm.GetAll();
            return PartialView(socialMedias);

        }
    }
}