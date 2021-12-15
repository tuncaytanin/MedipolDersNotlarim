using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class KasaMap: EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.ToTable("tblKasa");
            this.Property(p => p.KasaId).HasColumnType("int");
            this.Property(p => p.KasaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KasaAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KasaMiktari).HasPrecision(15, 2);
        }
    }
}
