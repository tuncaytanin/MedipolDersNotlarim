using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Category : IEntity
    {
        /*
            Adi,
            Aciklama
            Durumu
            Id
         */
        /// <summary>
        /// Unique  Define Category property
        /// </summary>
        /// 
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Kategori adını tutar.
        /// </summary>
        /// 
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Durumu, Aktif pasifliği gösterir
        /// </summary>
        public bool CategoryStatus { get; set; }

        public  virtual  ICollection<Post> Posts { get; set; }

    }
}
