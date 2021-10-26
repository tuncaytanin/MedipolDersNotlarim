using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class KitapMap : EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            this.ToTable("tblKitap");
            this.Property(p => p.KitapId).HasColumnType("int");
            this.Property(p => p.KitapId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KitapAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.SayfaSayisi).HasColumnType("smallint");
            this.Property(p => p.BasimYili).HasColumnType("char").HasMaxLength(4);

            this.HasRequired(p => p.YayinEvi).WithMany(p => p.Kitaps).HasForeignKey(p => p.YayinEviId);
            this.HasRequired(p => p.Kategori).WithMany(p => p.Kitaps).HasForeignKey(p => p.KategoriId);
            this.HasRequired(p => p.Yazar).WithMany(p => p.Kitaps).HasForeignKey(p => p.YazarId);
        }
    }
}
