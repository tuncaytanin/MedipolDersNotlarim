using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Repository;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.EntityFramework
{
    public class EfUserRepository : EntityRepositoryBase<User>, IUserDal
    {

    }
}