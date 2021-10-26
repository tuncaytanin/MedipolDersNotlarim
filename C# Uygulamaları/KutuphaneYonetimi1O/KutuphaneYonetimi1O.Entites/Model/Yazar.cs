using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{

    public class Yazar
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string DogumTarihi { get; set; }
        public bool YazarDurumu { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
