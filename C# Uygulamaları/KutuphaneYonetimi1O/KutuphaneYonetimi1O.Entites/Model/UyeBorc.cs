namespace KutuphaneYonetimi1O.Entites.Model
{
    public class UyeBorc
    {
        public int UyeBorcId { get; set; }
        public int PersonelId { get; set; }
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public int GunSayisi { get; set; }
        public decimal BorcMiktari { get; set; }
        public int KitapHareketId { get; set; }

        public virtual Kitap Kitap { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
