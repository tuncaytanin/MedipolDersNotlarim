﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _dal;
        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }
        
        public About GetFirstOrDefaultAbout()
        {
            return _dal.GetFirstModel();
        }

        public About GetFirstOrDefaultAbout(string photo)
        {
            return _dal.GetFirstModel(photo);
        }

        public List<About> GetWithPhotoAll(string photo)
        {
            return _dal.GetWithPhotos(photo);
        }

        public void Add(About entity)
        {
            _dal.Add(entity);
        }

        public void Delete(About entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByFilter(Expression<Func<About, bool>> filter)
        {
            _dal.DeleteByFilter(filter);
        }

        public void Update(About entity)
        {
            _dal.Update(entity);
        }

        public List<About> GetAll()
        {
            return _dal.GetAll();
        }

        public List<About> GetAllByFilter(Expression<Func<About, bool>> filter, string[] includes)
        {
            return _dal.GetAllByFilter(filter, includes);
        }

        public About GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public About GetModelByFilter(Expression<Func<About, bool>> filter, string[] includes)
        {
            return _dal.GetModelByFilter(filter, includes);
        }

    }
}