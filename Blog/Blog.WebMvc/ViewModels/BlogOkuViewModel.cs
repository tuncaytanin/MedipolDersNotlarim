using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.ViewModels
{
    public class BlogOkuViewModel
    {

        public Post Post { get; set; }

        public  IEnumerable<Comment> Comments { get; set; }

        public  IEnumerable<Post> Last3Posts { get; set; }
    }
}