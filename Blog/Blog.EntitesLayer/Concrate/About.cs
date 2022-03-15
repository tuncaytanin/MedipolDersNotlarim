using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Abstract;

namespace Blog.EntitesLayer.Concrate
{
    public class About: IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutContent { get; set; }
        public bool AboutStatus { get; set; }
        public int PhotoId { get; set; }

        public Photo Photo { get; set; }
    }
}
