using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Concrate;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.Repository;
using Blog.WebMvc.ViewModels;

namespace Blog.WebMvc.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager am = new AboutManager(new AboutRepository());
        private SocialMediaManager sm = new SocialMediaManager(new SocialMediaRepository());

        // GET: About
        public ActionResult Index()
        {

            AboutViewModel aboutViewModel = new AboutViewModel();

            // aboutViewModel göndericem..

            
            aboutViewModel.About = am.GetFirstOrDefaultAbout("Photo");
            aboutViewModel.SocialMedias = sm.GetAll();
            return View(aboutViewModel);
        }
    }
}