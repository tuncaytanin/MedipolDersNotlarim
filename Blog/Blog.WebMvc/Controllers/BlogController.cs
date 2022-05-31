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
        private CategoryManager ctgm = new CategoryManager(new EfCategoryRepository());
        
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
   
        [HttpGet]
        public ActionResult MyBlogList(int id)
        {
            string[] includes = { "Category", "Photo" ,"Writer"};
            var blogs = pm.GetAllByFilter(x => x.WriterId == id, includes);
            return View(blogs);

        }

        [HttpGet]
        public ActionResult New()
        {
            return View("FormBlog",new BlogNewViewModel() { Post = new Post() { PostId = 0 }, Categories = ctgm.GetAll() });
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var post = pm.GetModelById(id);
            if (post == null )
            {
                return HttpNotFound();
            }

            BlogNewViewModel bnvm = new BlogNewViewModel() { Post = post, Categories = ctgm.GetAll() };
            return View("FormBlog", bnvm);
        }
        [HttpPost]
        public ActionResult AddOrUpdate(Post post)
        {
            post.PostStatus = true;
            
            if (post.PostId == 0)
            {
                // Yeni bir Kayıt Ekleme
                post.CreateDate = DateTime.Now;
                post.CommentCount = 0;
                post.LikeCount = 0;
                post.PhotoId = 1;
                post.WriterId = 3;
                pm.Add(post);
            }
            else
            {
                // Güncelleme
                pm.Update(post);
            }

            return RedirectToAction("MyBlogList/3");
        }

    }
}