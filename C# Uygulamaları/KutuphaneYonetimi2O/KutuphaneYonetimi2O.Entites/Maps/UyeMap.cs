using KutuphaneYonetimi2O.Entites.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneYonetimi2O.Entites.Maps
{
    public class UyeMap : EntityTypeConfiguration<Uye>
    {
        // ctor -> 2 defa tab basarsanız, default constructor oluşturur
        public UyeMap()
        {
            this.Property(p => p.UyeId).HasColumnType("int");

            this.Property(p => p.UyeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.UyeAdi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.UyeEmail).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.UyeSoyadi).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.UyeTelefon).HasColumnType("nvarchar").HasMaxLength(15);
            this.Property(p => p.UyeCinsiyeti).HasColumnType("char").HasMaxLength(1);
            this.Property(p => p.DogumTarihi).HasColumnType("date");

        }
    }
}
