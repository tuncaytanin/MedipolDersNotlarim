using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Manager
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _dal;
        public CommentManager(ICommentDal dal)
        {
            _dal = dal;
        }

        public void Add(Comment entity)
        {
            _dal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByFilter(Expression<Func<Comment, bool>> filter)
        {
            _dal.DeleteByFilter(filter);
        }

        public void Update(Comment entity)
        {
            _dal.Update(entity);
        }

        public List<Comment> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Comment> GetAllByFilter(Expression<Func<Comment, bool>> filter, string[] includes)
        {
            return _dal.GetAllByFilter(filter, includes);
        }

        public Comment GetModelById(int id)
        {
            return _dal.GetModelById(id);
        }

        public Comment GetModelByFilter(Expression<Func<Comment, bool>> filter, string[] includes)
        {
            return _dal.GetModelByFilter(filter, includes);
        }

    }
}