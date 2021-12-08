using System.Collections.Generic;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class Kitap
    {
        /// <summary>
        ///  Ctrl + D basınca bir alt satıra kopyalar
        /// </summary>
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string KitapAciklama { get; set; }
        public string BasimYili { get; set; }
        public short SayfaSayisi { get; set; }
        
     
        //Todo Kitap durumunu char'a çevir. 
        /// <summary>
        /// Kitabın istem üzerindeki anlık durumunu bildirir. 
        /// A-> Akitf, P->Pasif ,S -> Silindi
        /// </summary>
        public bool KitapDurumu { get; set; }



        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
        public int YazarId { get; set; }

        public virtual Yazar Yazar { get; set; }
        public int YayinEviId { get; set; }

        public virtual YayinEvi YayinEvi { get; set; }

        public virtual ICollection<UyeBorc> UyeBorcs { get; set; }

        public virtual ICollection<KitapHareket> KitapHarekets { get; set; }
    }
}
