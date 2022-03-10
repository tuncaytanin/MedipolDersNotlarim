using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);

        void Delete(Category category);

        void Update(Category category);

        List<Category> GetAll();

        Category GetCategory(int id);
    }
}
