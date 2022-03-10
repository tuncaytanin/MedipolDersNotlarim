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
        public void Add(Comment comment)
        {
            _dal.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _dal.Delete(comment);
        }

        public void Update(Comment comment)
        {
            _dal.Update(comment);
        }

        public List<Comment> GetAll()
        {
            return _dal.GetAll();
        }

        public Comment GetComment(int id)
        {
            return _dal.GetComment(id);
        }
    }
}