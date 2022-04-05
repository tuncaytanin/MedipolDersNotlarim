using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Concrate
{
   public class PostManager : IPostService
   {
       private IPostDal _dal;
        public PostManager(IPostDal dal)
        {
            _dal = dal;
        }
        public void Add(Post entity)
        {
           _dal.Add(entity);
        }

        public void Delete(Post entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByFilter(Expression<Func<Post, bool>> filter)
        {
            _dal.DeleteByFilter(filter);
        }

        public void Update(Post entity)
        {
            _dal.Update(entity);
        }

        public List<Post> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Post> GetAllByFilter(Expression<Func<Post, bool>> filter, string[] includes)
        {
            return _dal.GetAllByFilter(filter, includes);
        }

        public Post GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public Post GetModelByFilter(Expression<Func<Post, bool>> filter, string[] includes)
        {
            return _dal.GetModelByFilter(filter, includes);
        }



        public List<Post> Bloglarim()
        {
            return _dal.Bloglar();
        }

        public List<Post> Last3Blogs()
        {
            return _dal.Last3Blogs();
        }
   }
}
