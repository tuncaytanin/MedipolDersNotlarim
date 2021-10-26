using KutuphaneYonetimi2O.Entites.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KutuphaneYonetimi2O.Entites.Maps
{
    public class UyeBorcMap : EntityTypeConfiguration<UyeBorc>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public UyeBorcMap()
        {
            this.Property(p => p.UyeBorcId).HasColumnType("int");

            this.Property(p => p.UyeBorcId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Miktar).HasPrecision(11, 2);
            this.Property(p => p.GunSayisi).HasColumnType("int");
            this.Property(p => p.KitapHareketId).HasColumnType("int");

            this.HasRequired(p => p.Kitap).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.KitapId);
            this.HasRequired(p => p.Uye).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.UyeId);
            this.HasRequired(p => p.Personel).WithMany(p => p.UyeBorcs).HasForeignKey(p => p.PersonelId);

        }
    }
}
