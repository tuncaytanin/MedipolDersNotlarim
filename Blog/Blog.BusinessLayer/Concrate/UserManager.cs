using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class UserManager : IUserService
    {
        private IUserDal _dal;

        public UserManager(IUserDal dal)
        {
            _dal = dal;
        }
        public void Add(User entity)
        {
            _dal.Add(entity);
        }

        public void Delete(User entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByFilter(Expression<Func<User, bool>> filter)
        {
            _dal.DeleteByFilter(filter);
        }

        public void Update(User entity)
        {
           _dal.Update(entity);
        }

        public List<User> GetAll()
        {
            return _dal.GetAll();
        }

        public List<User> GetAllByFilter(Expression<Func<User, bool>> filter, string[] includes)
        {
            return _dal.GetAllByFilter(filter, includes);

        }

        public User GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public User GetModelByFilter(Expression<Func<User, bool>> filter, string[] includes)
        {
            return _dal.GetModelByFilter(filter, includes);
        }
    }
}