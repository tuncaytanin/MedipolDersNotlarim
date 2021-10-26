using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class YazarMap:EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            this.ToTable("tblYazar");
            this.Property(p => p.YazarId).HasColumnType("int");
            this.Property(p => p.YazarId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YazarAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.YazarSoyadi).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
