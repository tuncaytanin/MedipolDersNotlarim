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


       public void Add(Category entity)
       {
           _dal.Add(entity);
       }

       public void Delete(Category entity)
       {
           _dal.Delete(entity);
       }

       public void Update(Category entity)
       {
           _dal.Update(entity);
       }

       public List<Category> GetAll()
       {
           return _dal.GetAll();
       }

       public Category GetModel(int id)
       {
           return _dal.GetModel(id);
       }
   }
}
