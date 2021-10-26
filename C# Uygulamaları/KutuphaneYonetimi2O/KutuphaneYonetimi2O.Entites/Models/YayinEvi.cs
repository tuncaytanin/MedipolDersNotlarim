
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Models
{
    public class YayinEvi
    {
        /// <summary>
        /// Kategori Tablosu
        /// </summary>
        public int YayinEviId { get; set; }
        public string YayinEviAdi { get; set; }
        public string Aciklama { get; set; }
        public bool YayinEviDurum { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
