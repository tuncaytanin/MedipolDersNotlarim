using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Abstract
{
    public interface IAboutDal
    {

    
        void Add(About about);

        void Delete(About about);

        void Update(About about);

        List<About> GetAll();

        About GetAbout(int id);

        About GetFirstModel();
        About GetFirstModel(string photo);

        List<About> GetWithPhotos(string photo);
    }
}
