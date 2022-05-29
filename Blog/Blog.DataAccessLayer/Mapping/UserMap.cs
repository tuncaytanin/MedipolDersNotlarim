using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("Users");
            this.Property(x => x.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.UserName).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.UserLastName).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.UserEmail).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(x => x.UserPassword).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.UserPhotoName).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.UserPhotoPath).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(x => x.UserPhotoThumpnailPath).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(x => x.UserTitel).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.UserAbout).HasColumnType("nvarchar").HasMaxLength(4000);
        }
    }
}