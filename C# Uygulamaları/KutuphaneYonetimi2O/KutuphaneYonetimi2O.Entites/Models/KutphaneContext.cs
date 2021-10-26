using KutuphaneYonetimi2O.Entites.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Models
{
    class KutphaneContext : DbContext
    {
        public KutphaneContext():base("name=Kutuphane2OEntites")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KitapHareketMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new UyeBorcMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new YayinEviMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new YetkiMap());
        }

        public  DbSet<Kategori> Kategori { get; set; }
        public  DbSet<Kitap> Kitap { get; set; }
        public  DbSet<KitapHareket> KitapHareket { get; set; }
        public  DbSet<Personel> Personel { get; set; }
        public  DbSet<Uye> Uye { get; set; }
        public  DbSet<UyeBorc> UyeBorc { get; set; }
        public  DbSet<YayinEvi> YayinEvi { get; set; }
        public  DbSet<Yazar> Yazar { get; set; }
        public  DbSet<Yetki> Yetki { get; set; }
    }
}
