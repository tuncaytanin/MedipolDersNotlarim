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
    public class KategoriMap: EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            this.Property(p => p.KategoriId).HasColumnType("int");
            this.Property(p => p.KategoriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KategoriAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

        }
    }
}
