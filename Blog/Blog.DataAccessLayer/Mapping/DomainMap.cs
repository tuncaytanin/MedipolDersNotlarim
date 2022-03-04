using Blog.EntitesLayer.Concrate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.DataAccessLayer.Mapping
{
    public class DomainMap:EntityTypeConfiguration<Domain>
    {
        public DomainMap()
        {
            this.Property(x => x.DomainId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.DomainName).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
