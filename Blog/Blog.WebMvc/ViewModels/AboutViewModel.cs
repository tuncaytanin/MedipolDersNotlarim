using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.ViewModels
{
    public class AboutViewModel
    {

        public  About About { get; set; }
        public IEnumerable<SocialMedia> SocialMedias { get; set; }
    }
}