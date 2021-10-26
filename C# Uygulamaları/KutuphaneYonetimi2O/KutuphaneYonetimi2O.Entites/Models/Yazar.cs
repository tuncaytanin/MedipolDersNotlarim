using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Models
{

    public class Yazar
    {

        /// <summary>
        /// Yazarlar Tablosu
        /// </summary>

        /*
         * prop -> 2 efa tab basılırsa otomatik properties oluşuru
         * Ctrl + D basılırsa bir alt satır kopyalanır
         */
        public int YazarId { get; set; }
        public String YazarAdi { get; set; }
        public String YazarSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool YazarDurum { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
