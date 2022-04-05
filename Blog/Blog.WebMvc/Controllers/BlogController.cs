using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Concrate;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;
using Blog.EntitesLayer.Concrate;
using Blog.WebMvc.ViewModels;

namespace Blog.WebMvc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private PostManager pm = new PostManager(new EfPostRepository());
        private CommentManager cm = new CommentManager(new EfCommentRepository());
        
        public ActionResult Index()
        {
            var posts = pm.Bloglarim();
            return View(posts);
        }

        public ActionResult BlogRead(int id)
        {

            BlogOkuViewModel blokOkuViewModel = new BlogOkuViewModel();
            string[] includes1 = {"Photo","Writer","Category"};
            blokOkuViewModel.Post = pm.GetModelByFilter(x => x.PostId == id, includes1);
       
            string[] includes2 = { "User" };
            blokOkuViewModel.Comments = cm.GetAllByFilter(x => x.PostId == id, includes2);

            string[] includes3 = { "Photo" };
            blokOkuViewModel.Last3PostsByWriterId =
                pm.GetAllByFilter(x => x.WriterId == blokOkuViewModel.Post.WriterId, includes3).Take(3);

            blokOkuViewModel.Last3PostsByCategoryId =
                pm.GetAllByFilter(x => x.CategoriId == blokOkuViewModel.Post.CategoriId, includes3).Take(3);

            return View(blokOkuViewModel);
        }

        public PartialViewResult Last3Post()
        {
            var posts = pm.Last3Blogs();
            return PartialView(posts);
        }
    }
}