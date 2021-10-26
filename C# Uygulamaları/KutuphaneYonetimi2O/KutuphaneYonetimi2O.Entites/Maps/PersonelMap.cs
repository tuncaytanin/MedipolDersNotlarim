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

    public class PersonelMap : EntityTypeConfiguration<Personel>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public PersonelMap()
        {
            this.Property(p => p.PersonelId).HasColumnType("int");

            this.Property(p => p.PersonelId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.PersonelAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.PersonelEmail).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.PersonelSoyadi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.PersonelKAdi).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(p => p.PersonelParola).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(p => p.DogumTarihi).HasColumnType("date");

            this.HasRequired(p => p.Yetki).WithMany(p => p.Personels).HasForeignKey(p => p.YetkiId);

        }
    }
}
