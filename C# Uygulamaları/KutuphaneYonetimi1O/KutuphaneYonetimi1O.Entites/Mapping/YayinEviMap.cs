using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{

    public class YayinEviMap : EntityTypeConfiguration<YayinEvi>
    {
        public YayinEviMap()
        {
            this.ToTable("tblYayinEvi");
            this.Property(p => p.YayinEviId).HasColumnType("int");
            this.Property(p => p.YayinEviId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YayinEviAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.YayinEviAciklama).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
