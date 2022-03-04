using Blog.EntitesLayer.Concrate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.DataAccessLayer.Mapping
{

    public class CommentMap:EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.Property(x => x.CommentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.CommentTitle).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.CommentContent).HasColumnType("nvarchar").HasMaxLength(4000);
            

        }
    }
}
