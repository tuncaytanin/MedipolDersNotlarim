using System.ComponentModel.DataAnnotations;
using Blog.EntitesLayer.Abstract;

namespace Blog.EntitesLayer.Concrate
{


    public class Folower : IEntity
    {
        [Key]
        public  int FolowerId { get; set; }
        public int TakiEdenId { get; set; }
        public  User TakipEden { get; set; }

        public  int TakipEdilenId { get; set; }
        public User TakipEdilen { get; set; }
    }
}