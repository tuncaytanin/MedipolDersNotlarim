using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Repository;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.EntityFramework
{
   public class EfPostRepository : EntityRepositoryBase<Post>,IPostDal
    {
        public List<Post> Bloglar()
        {
            return db.Posts.Include("Photo").ToList();
        }

        public List<Post> Last3Blogs()
        {
            return db.Posts.Include("Photo").Take(3).ToList();
        }
    }
}
