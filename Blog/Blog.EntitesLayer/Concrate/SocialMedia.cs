using System.ComponentModel.DataAnnotations;
using Blog.EntitesLayer.Abstract;

namespace Blog.EntitesLayer.Concrate
{
    public class SocialMedia : IEntity
    {
        [Key] public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaIconClass { get; set; }

        public  string  SocialMediaFolowerCount { get; set; }

        public  bool SocialMediaStatus { get; set; }

        public  string SocialMediaLink { get; set; }
    }
}