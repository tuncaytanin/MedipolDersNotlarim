using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Abstract;

namespace Blog.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity:IEntity
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        List<TEntity> GetAll();


      //  List<TEntity> GetEntitesByFilter();
        TEntity GetModel(int id);
    }
}
