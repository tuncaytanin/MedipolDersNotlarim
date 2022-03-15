using System;
using System.Collections.Generic;
using System.Linq;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Concrate;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Xpo.Helpers;

namespace Blog.DataAccessLayer.Repository
{
    public class SocialMediaRepository : ISocialMediaDal
    {
        private BlogContext db;
        public SocialMediaRepository()
        {
            db = new BlogContext();
        }
        public void Add(SocialMedia socialMedia)
        {
            db.SocialMedias.Add(socialMedia);
        }

        public void Delete(SocialMedia socialMedia)
        {
            throw new NotImplementedException();
        }

        public void Update(SocialMedia socialMedia)
        {
            throw new NotImplementedException();
        }

        public List<SocialMedia> GetAll()
        {
            return db.SocialMedias.AsNoTracking().Where(x=>x.SocialMediaStatus==true).ToList();
        }

        public SocialMedia GetSocialMedia(int id)
        {
            throw new NotImplementedException();
        }

        public SocialMedia GetFirstModel()
        {
            throw new NotImplementedException();
        }
    }
}