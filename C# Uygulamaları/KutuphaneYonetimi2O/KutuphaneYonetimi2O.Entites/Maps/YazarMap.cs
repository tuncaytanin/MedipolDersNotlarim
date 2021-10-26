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
    public class YazarMap:EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            this.Property(p => p.YazarId).HasColumnType("int");

            this.Property(p => p.YazarId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YazarAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.YazarSoyadi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.DogumTarihi).HasColumnType("date");

        }
    }
}
