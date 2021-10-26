using KutuphaneYonetimi2O.Entites.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneYonetimi2O.Entites.Maps
{
    public class YetkiMap : EntityTypeConfiguration<Yetki>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public YetkiMap()
        {
            this.Property(p => p.YetkiId).HasColumnType("int");

            this.Property(p => p.YetkiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YetkiAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
