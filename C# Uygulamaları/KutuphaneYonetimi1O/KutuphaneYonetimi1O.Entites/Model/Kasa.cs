using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi1O.Entites.Model
{
   public class Kasa
    {
        /// <summary>
        /// int,Kasanın uniq degerini tutuar
        /// </summary>
        public int KasaId { get; set; }

        /// <summary>
        /// Kasanın adını tutar
        /// </summary>
        public string KasaAdi { get; set; }
        /// <summary>
        /// true -> Aktif, false -> pasif
        /// </summary>
        public bool KasaDurumu { get; set; }
        /// <summary>
        /// Kasada bulunan toplam miktarı tutar
        /// </summary>
        public decimal KasaMiktari { get; set; }

        /// <summary>
        /// Bir tane varsayilan kasa olabilir
        /// </summary>
        public bool VarsayilanKasa { get; set; }

    }
}
