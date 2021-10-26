using KutuphaneYonetimi1O.Entites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{
    public class UyeBorcMap : EntityTypeConfiguration<UyeBorc>
    {
        public UyeBorcMap()
        {
            this.ToTable("tblUyeBorc");
            this.Property(p => p.UyeBorcId).HasColumnType("int");
            this.Property(p => p.UyeBorcId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.BorcMiktari).HasPrecision(11, 2);

            this.HasRequired(p => p.Personel).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.PersonelId);
            this.HasRequired(p => p.Uye).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.UyeId);
            this.HasRequired(p => p.Kitap).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.KitapId);
        }
    }
}
