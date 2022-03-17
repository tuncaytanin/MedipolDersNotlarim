using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Mapping
{
    public class SocialMediaMap : EntityTypeConfiguration<SocialMedia>
    {
        public SocialMediaMap()
        {
            this.Property(x => x.SocialMediaFolowerCount).HasColumnType("nvarchar").HasMaxLength(10);
            this.Property(x => x.SocialMediaIconClass).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.SocialMediaClass).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.SocialMediaName).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.SocialMediaLink).HasColumnType("nvarchar").HasMaxLength(200);

        }
    }
}
