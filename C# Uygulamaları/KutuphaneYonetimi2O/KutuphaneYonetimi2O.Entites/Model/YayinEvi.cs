using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class YayinEvi
    {
        public int YayinEviId { get; set; }
        public string YayinEviAdi { get; set; }
        public bool YayinEviDurumu { get; set; }
        public string YayinEviAciklama { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
