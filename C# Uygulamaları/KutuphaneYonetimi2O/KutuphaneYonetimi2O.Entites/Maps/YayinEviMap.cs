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



    public class YayinEviMap:EntityTypeConfiguration<YayinEvi>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public YayinEviMap()
        {
            this.Property(p => p.YayinEviId).HasColumnType("int");

            this.Property(p => p.YayinEviId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YayinEviAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
