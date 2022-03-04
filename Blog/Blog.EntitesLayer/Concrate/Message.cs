using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Message : IEntity
    {
        public int MessageId { get; set; }

        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }

        public DateTime CreateDate { get; set; }


        public int MessageSenderId { get; set; }
        public User MessageSender { get; set; }

        public int MessageReciverId { get; set; }
        public User MessageReciver { get; set; }

        public bool IsRead { get; set;
        }
    }
}
