using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class YetkiMap : EntityTypeConfiguration<Yetki>
    {
        public YetkiMap()
        {
            this.ToTable("tblYetki");
            this.Property(p => p.YetkiId).HasColumnType("int");
            this.Property(p => p.YetkiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YetkiAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.YetkiAciklama).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
