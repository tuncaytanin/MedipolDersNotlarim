
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi2O.Entites.Models
{
    public class Kitap
    {
        /// <summary>
        /// Kitap Tablosu
        /// </summary>
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }

        public int KategoriId { get; set; }

        public int YazarId { get; set; }
        public int YayinEviId { get; set; }
        public string Aciklama { get; set; }

        public string BasimYili { get; set; }
        public bool KitapDurumu { get; set; }
        public short SayfaSayisi { get; set; }


        public virtual Yazar Yazar { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual YayinEvi YayinEvi { get; set; }

        public virtual ICollection<UyeBorc> UyeBorcs { get; set; }
        public virtual ICollection<KitapHareket> KitapHarekets { get; set; }

    }
}
