using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class Yetki
    {
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; }
        public string YetkiAciklama { get; set; }
        public bool YetkiDurumu { get; set; }

        public virtual ICollection<Personel> Personels { get; set; }
    }
}
