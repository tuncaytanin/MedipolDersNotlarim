using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class DomainManager : IDomainService
    {
        private IDomainDal _dal;
        public DomainManager(IDomainDal dal)
        {
            _dal = dal;
        }

        public void Add(Domain entity)
        {
            _dal.Add(entity);
        }

        public void Delete(Domain entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByFilter(Expression<Func<Domain, bool>> filter)
        {
             _dal.DeleteByFilter(filter);
        }

        public List<Domain> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Domain> GetAllByFilter(Expression<Func<Domain, bool>> filter, string[] includes)
        {
            return _dal.GetAllByFilter(filter, includes);
        }

        public Domain GetModelByFilter(Expression<Func<Domain, bool>> filter, string[] includes)
        {
            return _dal.GetModelByFilter(filter, includes);
        }

        public Domain GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public void Update(Domain entity)
        {
            _dal.Update(entity);
        }
    }
}