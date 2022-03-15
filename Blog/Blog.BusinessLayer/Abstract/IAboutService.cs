using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

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
    }
}
