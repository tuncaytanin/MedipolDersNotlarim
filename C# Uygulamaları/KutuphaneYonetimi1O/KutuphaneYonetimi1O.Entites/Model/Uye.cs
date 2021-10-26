using System;
using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class Uye
    {
        public int UyeId { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeEmail { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public bool UyeDurumu { get; set; }

        public virtual ICollection<UyeBorc> UyeBorcs { get; set; }

        public virtual ICollection<KitapHareket> KitapHarekets { get; set; }
    }
}
