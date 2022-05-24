using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Concrate;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;
using Blog.DataAccessLayer.Repository;
using Blog.EntitesLayer.Concrate;
using Blog.WebMvc.ViewModels;

namespace Blog.WebMvc.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager am = new AboutManager(new EfAboutRepository());
        private SocialMediaManager sm = new SocialMediaManager(new EfSocialMediaRepository());
        private PhotoManager pm = new PhotoManager(new EfPhotoRepository());
        // GET: About
        public ActionResult Index()
        {

            AboutViewModel aboutViewModel = new AboutViewModel();

            // aboutViewModel göndericem..

            
            aboutViewModel.About = am.GetFirstOrDefaultAbout("Photo");
            aboutViewModel.SocialMedias = sm.GetAll();
            return View(aboutViewModel);
        }
    
        public ActionResult List()
        {
            var abouts = am.GetAll();
            return View(abouts);
        }

        public ActionResult Delete(int id)
        {
            var about = am.GetModelById(id);
            if (about == null)
                return HttpNotFound();
            about.AboutStatus = false;
            am.Update(about);
            return RedirectToAction("List");

        }

        [HttpGet]
        public ActionResult Update(int id)
        {

            string[] includes = { "Photo" };
            var about = am.GetModelByFilter(x=>x.AboutId ==id, includes);
            if (about == null)
                return HttpNotFound($"{id} ait bir hakkımda bulunamadı");
            return View("FormAbout", about);
        }

        [HttpGet]
        public ActionResult New()
        {
            About about = new About { AboutId = 0 };

            return View("FormAbout",about);
        }
    
        [HttpPost]
        public ActionResult AddOrUpdate(About pAbout)
        {
            pAbout.AboutStatus = true;

            if (pAbout.AboutId == 0)
            {
                // Id => 0 ise yeni bir about ekliyoruz
                pAbout.PhotoId = 2;
                pAbout.Photo = pm.GetModelById(2);
                am.Add(pAbout);
            }
            else
            {
                // I=> 0 dan farklı ise about güncelliyoruz

                am.Update(pAbout);
            }


            return RedirectToAction("List","About");

        }
    }
}