using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class FolowerMap : EntityTypeConfiguration<Folower>
    {
        public FolowerMap()
        {
            this.Property(x => x.FolowerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            
        }
    }
}