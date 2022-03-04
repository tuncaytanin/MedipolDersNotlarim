using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Photo: IEntity
    {
        [Key]
        public int PhotoId { get; set; }

        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoTumbnail { get; set; }
    }
}
