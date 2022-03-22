using Blog.DataAccessLayer.Mapping;
using Blog.EntitesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Context
{
    public class BlogContext :DbContext
    {
        public BlogContext():base("name=DbBlogMvcEntities")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new DomainMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new PhotoMap());
            modelBuilder.Configurations.Add(new AboutMap());
            modelBuilder.Configurations.Add(new SocialMediaMap());

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public  DbSet<About> Abouts { get; set; }

        public  DbSet<SocialMedia> SocialMedias { get; set; }

    }
}
