using System.Collections.Generic;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Abstract
{


    public interface IAboutService:IGenericService<About>
    {
        About GetFirstOrDefaultAbout();
        About GetFirstOrDefaultAbout(string photo);

        List<About> GetWithPhotoAll(string photo);

    }
}
