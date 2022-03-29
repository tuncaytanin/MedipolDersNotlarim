using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Comment: IEntity
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }

        public DateTime CommentDateTime { get; set; }
        public int PostId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
        
    }
}
