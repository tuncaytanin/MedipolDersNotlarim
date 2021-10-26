using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi1O.Entites.Model
{

    public class Kategori
    {
        /// <summary>
        /// Kategori bilgilerinin tutulduğu tablo yapısı
        /// </summary>

        /*
         *  prop -> 2 defa tab otomatik properties oluşturur
         * 
         */

        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public bool KategoriDurumu { get; set; }
        public string KategoriAciklama { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
