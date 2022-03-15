using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Repository
{


    public class CategoryRepository : ICategoryDal
   {
       private BlogContext db;

       public CategoryRepository()
       {
           db = new BlogContext();
       }
        public void Add(Category category)
        {
            db.Categories.Add(category);
        }

        public void Delete(Category category)
        {
            db.Categories.Remove(category);
        }

        public void Update(Category category)
        {
            db.SaveChanges();
        }



        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
