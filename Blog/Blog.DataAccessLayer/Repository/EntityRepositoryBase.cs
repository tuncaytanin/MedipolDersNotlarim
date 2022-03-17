using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Context;
using Blog.EntitesLayer.Abstract;

namespace Blog.DataAccessLayer.Repository
{
    public class EntityRepositoryBase<TEntity> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
    {
        public BlogContext db;
        public DbSet<TEntity> _object;

        public EntityRepositoryBase()
        {
            db = new BlogContext();
            _object = db.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _object.Add(entity);
            db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _object.Remove(entity);
            db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _object.ToList();
        }

        public TEntity GetModel(int id)
        {
            return _object.Find(id);
        }
    }
}
