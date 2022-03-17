using System;
using System.Collections.Generic;
using System.Linq;
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

        void Update(TEntity entity);

        List<TEntity> GetAll();

        TEntity GetModel(int id);
    }
}
