using System.Collections.Generic;

namespace Blog.BusinessLayer.Abstract
{


    public interface IAboutService<About>
    {
        void Add(About about);

        void Delete(About about);

        void Update(About about);

        List<About> GetAll();

        About GetCategory(int id);

        About GetFirstOrDefaultAbout();
        About GetFirstOrDefaultAbout(string photo);

        List<About> GetWithPhotoAll(string photo);

    }
}
