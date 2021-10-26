using KutuphaneYonetimi1O.Entites.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class KutuphaneContext:DbContext
    {
        public KutuphaneContext():base("name=Kutuphane1OEntites")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new YayinEviMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new UyeBorcMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new YetkiMap());
            modelBuilder.Configurations.Add(new KitapHareketMap());
        }


        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<YayinEvi> YayinEvi { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<UyeBorc> UyeBorc { get; set; }
        public DbSet<KitapHareket> KitapHareket { get; set; }
        public DbSet<Yetki> Yetki { get; set; }
        public DbSet<Personel> Personel { get; set; }
    }
}
