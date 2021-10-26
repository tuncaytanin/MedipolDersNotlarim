using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneYonetimi2O.Entites.Models
{
    public class Uye
    {
        /// <summary>
        /// Üye Tablosu
        /// </summary>
        public int UyeId { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeEmail { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string UyeCinsiyeti { get; set; }
        public string UyeTelefon { get; set; }
        public bool UyeDurumu { get; set; }

        public virtual ICollection<UyeBorc> UyeBorcs { get; set; }

        public virtual ICollection<KitapHareket> KitapHarekets { get; set; }
    }
}
