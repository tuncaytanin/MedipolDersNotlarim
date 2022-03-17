using System;
using System.Collections.Generic;
using System.Linq;
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

       public void Update(SocialMedia entity)
       {
          _dal.Update(entity);
       }

       public List<SocialMedia> GetAll()
       {
           return _dal.GetAll();
       }

       public SocialMedia GetModel(int id)
       {
           return _dal.GetModel(id);
       }
   }
}
