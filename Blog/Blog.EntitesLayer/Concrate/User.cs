using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class User: IEntity
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name="Kullanıcı Adı")]
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserStatus { get; set; }
        public string ForgetPassword { get; set; }
        public bool IsValidForgetPassword { get; set; }
        public int DomainId { get; set; }
        public Domain Domain { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual  ICollection<Post> Posts { get; set; }

        public string UserPhotoName { get; set; }
        public string UserPhotoPath { get; set; }
        public string UserPhotoThumpnailPath { get; set; }

    }
}
