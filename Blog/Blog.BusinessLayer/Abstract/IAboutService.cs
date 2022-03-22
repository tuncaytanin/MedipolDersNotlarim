using Blog.EntitesLayer.Concrate;
using System.Collections.Generic;

namespace Blog.BusinessLayer.Abstract
{


    public interface IAboutService:IGenericService<About>
    {
        About GetFirstOrDefaultAbout();
        About GetFirstOrDefaultAbout(string photo);

        List<About> GetWithPhotoAll(string photo);

    }
}
