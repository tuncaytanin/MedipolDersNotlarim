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
     class CommentRepository:ICommentDal
    {
        private BlogContext db;
        public CommentRepository()
        {
            db = new BlogContext();
        }
        public void Add(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public void Delete(Comment comment)
        {
            db.Comments.Remove(comment);
            db.SaveChanges();
        }

        public void Update(Comment comment)
        {
            db.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return db.Comments.ToList();
        }

        public Comment GetComment(int id)
        {
            return db.Comments.Find(id);
        }
    }
}
