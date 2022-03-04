using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Post: IEntity
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        public int WriterId { get; set; }

        public int PhotoId { get; set; }

        public Photo Photo { get; set; }

        public int CommentCount { get; set; }

        public  int LikeCount { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
