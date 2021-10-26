using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneYonetimi2O.Entites.Models
{

    public class Kategori
    {
        /// <summary>
        /// Kategori Tablosu
        /// </summary>
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public bool KategoriDurum { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
