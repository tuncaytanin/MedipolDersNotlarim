using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(x => x.PostId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.PostContent).HasColumnType("nvarchar");
            this.Property(x => x.PostTitle).HasColumnType("nvarchar").HasMaxLength(200);


            this.HasRequired(x => x.Writer).WithMany(x => x.Posts).HasForeignKey(x => x.WriterId);
            this.HasRequired(x => x.Category).WithMany(x => x.Posts).HasForeignKey(x => x.CategoriId);
        }
    }
}