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
    public class EfAboutRepository : EntityRepositoryBase<About>, IAboutDal
    {

        public About GetFirstModel()
        {
            return _object.SingleOrDefault(x => x.AboutStatus == true);
        }

        public About GetFirstModel(string photo)
        {
            return _object.Include(photo).SingleOrDefault(x => x.AboutStatus == true);
        }

        public List<About> GetWithPhotos(string photo)
        {
            return _object.Include(photo).ToList();

        }
    }
}
