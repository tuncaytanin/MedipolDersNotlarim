using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntitesLayer.Concrate;

namespace Blog.BusinessLayer.Concrate
{
   public class SocialMediaManager:ISocialMediaService
   {

       private ISocialMediaDal _dal;

       public SocialMediaManager(ISocialMediaDal dal)
       {
           _dal = dal;
       }


       public void Add(SocialMedia entity)
       {
           _dal.Add(entity);
       }

       public void Delete(SocialMedia entity)
       {
           _dal.Delete(entity);
       }

       public void DeleteByFilter(Expression<Func<SocialMedia, bool>> filter)
       {
           _dal.DeleteByFilter(filter);
       }

       public void Update(SocialMedia entity)
       {
          _dal.Update(entity);
       }

       public List<SocialMedia> GetAll()
       {
           return _dal.GetAll();
       }

       public List<SocialMedia> GetAllByFilter(Expression<Func<SocialMedia, bool>> filter, string[] includes)
       {
           return _dal.GetAllByFilter(filter, includes);
       }

       public SocialMedia GetModelById(int id)
       {
           return _dal.GetModelById(id);
       }

       public SocialMedia GetModelByFilter(Expression<Func<SocialMedia, bool>> filter, string[] includes)
       {
           return _dal.GetModelByFilter(filter, includes);
       }

   }
}
