using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1O.Entites.Mapping
{

    public class KategoriMap: EntityTypeConfiguration<Kategori>
    {
        /// <summary>
        /// ctor -> 2 defa tab otomatik constructor oluşturur
        /// </summary>
        public KategoriMap()
        {
            this.ToTable("tblKategori");
            this.Property(p => p.KategoriId).HasColumnType("int");
            this.Property(p => p.KategoriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KategoriAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KategoriAciklama).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
