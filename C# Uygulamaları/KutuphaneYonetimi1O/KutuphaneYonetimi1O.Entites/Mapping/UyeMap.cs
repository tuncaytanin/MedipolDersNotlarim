using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class UyeMap : EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            this.ToTable("tblUye");
            this.Property(p => p.UyeId).HasColumnType("int");
            this.Property(p => p.UyeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.UyeAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.UyeSoyadi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.UyeEmail).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.DogumTarihi).HasColumnType("date");
        }
    }
}
