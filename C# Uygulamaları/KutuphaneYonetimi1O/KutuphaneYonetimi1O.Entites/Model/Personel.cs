using System;
using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelEmail { get; set; }
        public string PersonelKAdi { get; set; }
        public string PersonelParola { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool PersonelDurumu { get; set; }
        public int YetkiId { get; set; }

        public virtual Yetki Yetki { get; set; }

        public virtual ICollection<UyeBorc> UyeBorcs { get; set; }

        public virtual ICollection<KitapHareket> KitapHarekets { get; set; }
    }
}
