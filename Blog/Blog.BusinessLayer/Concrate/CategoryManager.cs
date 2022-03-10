using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class CategoryManager:ICategoryService
   {
       private ICategoryDal _dal;

       public CategoryManager(ICategoryDal dal)
       {
           _dal = dal;
       }
        public void Add(Category category)
        {
            _dal.Add(category);

        }

        public void Delete(Category category)
        {
            _dal.Delete(category);
        }

        public void Update(Category category)
        {
            _dal.Update(category);
        }

        public List<Category> GetAll()
        {
            return _dal.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _dal.GetCategory(id);
        }
    }
}
