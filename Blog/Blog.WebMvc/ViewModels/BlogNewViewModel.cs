using Blog.EntitesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebMvc.ViewModels
{
    public class BlogNewViewModel
    {
        public Post Post { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}