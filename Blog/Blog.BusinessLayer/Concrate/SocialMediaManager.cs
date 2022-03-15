using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Concrate
{
   public class SocialMediaManager:ISocialMediaService<SocialMedia>
   {

       private ISocialMediaDal _dal;

       public SocialMediaManager(ISocialMediaDal dal)
       {
           _dal = dal;
       }
        public void Add(SocialMedia socialMedia)
        {
            _dal.Add(socialMedia);
        }

        public void Delete(SocialMedia socialMedia)
        {
            _dal.Delete(socialMedia);
        }

        public void Update(SocialMedia socialMedia)
        {
            _dal.Update(socialMedia);
        }

        public List<SocialMedia> GetAll()
        {
            return _dal.GetAll();
        }

        public SocialMedia GetSocialMedia(int id)
        {
            return _dal.GetSocialMedia(id);
        }
    }
}
