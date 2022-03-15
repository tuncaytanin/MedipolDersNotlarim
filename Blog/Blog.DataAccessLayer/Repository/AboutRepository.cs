using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Repository
{
    public class AboutRepository:IAboutDal
    {
        private BlogContext db;
        public AboutRepository()
        {
            db = new BlogContext();
        }
        public void Add(About about)
        {
            db.Abouts.Add(about);
            db.SaveChanges();
        }

        public void Delete(About about)
        {
            throw new NotImplementedException();
        }

        public void Update(About about)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            return db.Abouts.ToList();
        }

        public About GetAbout(int id)
        {
            return db.Abouts.Find(id);
        }

        public About GetFirstModel()
        {
            return db.Abouts.SingleOrDefault(x => x.AboutStatus == true);
        }

        public About GetFirstModel(string photo)
        {
            return db.Abouts.Include(photo).SingleOrDefault(x => x.AboutStatus == true);
        }


        public List<About> GetWithPhotos(string photo)
        {
            return db.Abouts.Include(photo).ToList();
        }
    }
}
