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
    public class EfSocialMediaRepository : EntityRepositoryBase<SocialMedia> , ISocialMediaDal
    {

        // EntityRepositoryBase içerisinde metotlardan dışında başka bir işlem yapacaksam
        // Ozaman onları burada yapıcağız!
    }
}
