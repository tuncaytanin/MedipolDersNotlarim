using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KutuphaneYonetimi2O.Entites.Models
{
    public class Yetki
    {
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; }
        public string Aciklama { get; set; }
        public bool YetkiDurumu { get; set; }    
        public   virtual ICollection<Personel> Personels { get; set; }
    }
}
