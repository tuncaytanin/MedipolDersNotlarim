using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            return _dal.GetAll();
        }

        public Post GetModel(int id)
        {
            return _dal.GetModel(id);
        }

        public List<Post> Bloglarim()
        {
            return _dal.Bloglar();
        }
   }
}
