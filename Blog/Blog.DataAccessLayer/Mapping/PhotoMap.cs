using Blog.EntitesLayer.Concrate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.DataAccessLayer.Mapping
{
    /*
     * ctrl + . => otomatik öneriler geliyor
     */
    public class PhotoMap:EntityTypeConfiguration<Photo>
    {
        public PhotoMap()
        {
            this.Property(x => x.PhotoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.PhotoName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.PhotoPath).HasColumnType("varchar").HasMaxLength(250);
            this.Property(x => x.PhotoTumbnail).HasColumnType("varchar").HasMaxLength(250);
            
        }
    }
}
