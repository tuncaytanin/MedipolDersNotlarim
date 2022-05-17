using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public ActionResult Index()
        {

            var categories = cm.GetAll();
            return View(categories);
        }

        public ActionResult Delete(int id)
        {
            var category = cm.GetModelById(id);
            if (category!=null)
            {
                category.CategoryStatus = false;
                cm.Update(category);
                return RedirectToAction("Index","Category");
            }

            return HttpNotFound();
        }

        [HttpGet]

        public ActionResult Update(int id)
        {
            var category = cm.GetModelById(id);

            if (category == null)
            {
                return HttpNotFound();
            }

            return View("CategoryForm",category);
        }

        [HttpGet]
        public ActionResult New()
        {

            return View("CategoryForm", new Category());
        }

        [HttpPost]
        public ActionResult Save(Category pcategory)
        {
            if (pcategory.CategoryId == 0)
            {
                // Yeni bir category ekliyorum
                pcategory.CategoryStatus = true;
                cm.Add(pcategory);
            }
            else
            {
                //Category güncelleme yapıyorum
                pcategory.CategoryStatus = true;
                cm.Update(pcategory);
            }

            return RedirectToAction("Index");
        }
    }
}