using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class SubscripeMap : EntityTypeConfiguration<Subscripe>
    {
        public SubscripeMap()
        {
            this.Property(x => x.SubscripeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Email).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(x => x.ActivationCode).HasColumnType("nvarchar").HasMaxLength(64);
        }
    }
}