using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.Dtos
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }

        public int DomainId { get; set; }
        public Domain Domain { get; set; }

        public string UserPhotoName { get; set; }
        public string UserPhotoPath { get; set; }
        public string UserPhotoThumpnailPath { get; set; }
    }
}