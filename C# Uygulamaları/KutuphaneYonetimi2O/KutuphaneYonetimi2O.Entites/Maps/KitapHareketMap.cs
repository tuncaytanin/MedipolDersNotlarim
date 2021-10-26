using KutuphaneYonetimi2O.Entites.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace KutuphaneYonetimi2O.Entites.Maps
{
    public class KitapHareketMap : EntityTypeConfiguration<KitapHareket>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public KitapHareketMap()
        {
            this.Property(p => p.KitapHareketId).HasColumnType("int");

            this.Property(p => p.KitapHareketId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.AlmaTarihi).HasColumnType("date");
            this.Property(p => p.IadeTarihi).HasColumnType("date");
            this.Property(p => p.KullaniciIadeTarihi).HasColumnType("date");

            this.HasRequired(p => p.Kitap).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.KitapId);
            this.HasRequired(p => p.Uye).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.UyeId);
            this.HasRequired(p => p.Personel).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.PersonelId);

        }
    }
}
