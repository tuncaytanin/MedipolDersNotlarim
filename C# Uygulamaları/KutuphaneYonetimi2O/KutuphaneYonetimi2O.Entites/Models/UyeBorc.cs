using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Models
{
    public class UyeBorc
    {
        public int UyeBorcId { get; set; }
        public int PersonelId { get; set; }
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public int GunSayisi { get; set; }
        public int KitapHareketId { get; set; }
        public decimal Miktar { get; set; }

        public virtual Uye Uye { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Kitap Kitap { get; set; }

    }
}
