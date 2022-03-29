using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Concrate;
using Blog.DataAccessLayer.EntityFramework;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private PostManager pm = new PostManager(new EfPostRepository());
        
        public ActionResult Index()
        {
            var posts = pm.Bloglarim();
            return View(posts);
        }

        public ActionResult BlogOku(int id)
        {

            Post post = pm.GetModelById(id);
            return View(post);
        }
    }
}