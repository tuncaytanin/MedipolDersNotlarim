using KutuphaneYonetimi2O.Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Maps
{

    public class KitapMap:EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            
            this.Property(p => p.KitapId).HasColumnType("int");

            this.Property(p => p.KitapId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KitapAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.SayfaSayisi).HasColumnType("smallint");
            this.Property(p => p.BasimYili).HasColumnType("char").HasMaxLength(4);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar");

            this.HasRequired(p => p.Kategori).WithMany(p => p.Kitaps).HasForeignKey(p => p.KategoriId);
            this.HasRequired(p => p.YayinEvi).WithMany(p => p.Kitaps).HasForeignKey(p => p.YayinEviId);
            this.HasRequired(p => p.Yazar).WithMany(p => p.Kitaps).HasForeignKey(p => p.YazarId);
        }
    }
}
