using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class AboutMap : EntityTypeConfiguration<About>
    {
        public AboutMap()
        {
            this.Property(x => x.AboutId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.AboutTitle).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(x => x.AboutContent).HasColumnType("nvarchar");
        }
    }
}