using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Abstract
{
    public interface IAboutDal : IGenericDal<About>
    {

        About GetFirstModel();
        About GetFirstModel(string photo);

        List<About> GetWithPhotos(string photo);
    }
}
