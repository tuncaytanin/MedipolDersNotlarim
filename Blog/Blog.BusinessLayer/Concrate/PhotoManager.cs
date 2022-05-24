using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class PhotoManager: IPhotoService
    {
        private IPhotoDal _dal;

        public PhotoManager(IPhotoDal dal)
        {
            _dal = dal;
        }

        public void Add(Photo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Photo entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByFilter(Expression<Func<Photo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetAllByFilter(Expression<Func<Photo, bool>> filter, string[] includes)
        {
            throw new NotImplementedException();
        }

        public Photo GetModelByFilter(Expression<Func<Photo, bool>> filter, string[] includes)
        {
            throw new NotImplementedException();
        }

        public Photo GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public void Update(Photo entity)
        {
            throw new NotImplementedException();
        }
    }
}