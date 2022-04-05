using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Abstract
{
    public interface IPostService : IGenericService<Post>
    {
        List<Post> Bloglarim();

        List<Post> Last3Blogs();
    }
}
