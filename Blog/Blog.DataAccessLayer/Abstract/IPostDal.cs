using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Abstract
{
    public interface IPostDal : IGenericDal<Post>
    {

        List<Post> Bloglar();
    }
}
