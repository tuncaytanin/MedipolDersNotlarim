using System.Collections.Generic;
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

        public void Update(Comment entity)
        {
            _dal.Update(entity);
        }

        public List<Comment> GetAll()
        {
            return _dal.GetAll();
        }

        public Comment GetModel(int id)
        {
            return _dal.GetModel(id);
        }
    }
}