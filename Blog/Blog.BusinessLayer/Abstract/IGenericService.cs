using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Abstract;

namespace Blog.BusinessLayer.Abstract
{
    public interface IGenericService<TEntity>
    where TEntity: class,IEntity, new()
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void DeleteByFilter(Expression<Func<TEntity, bool>> filter );

        void Update(TEntity entity);

        List<TEntity> GetAll();
        List<TEntity> GetAllByFilter(Expression<Func<TEntity, bool>> filter,string[] includes);

        TEntity GetModelById(int id);

        TEntity GetModelByFilter(Expression<Func<TEntity, bool>> filter, string[] includes);
    }
}
