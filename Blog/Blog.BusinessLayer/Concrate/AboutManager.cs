using System;
using System.Collections.Generic;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class AboutManager : IAboutService<About>
    {
        private IAboutDal _dal;
        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }
        public void Add(About about)
        {
            throw new NotImplementedException();
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
            return _dal.GetAll();
        }

        public About GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public About GetFirstOrDefaultAbout()
        {
            return _dal.GetFirstModel();
        }
    }
}