using Blog.EntitesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntitesLayer.Concrate
{
    public class Domain: IEntity
    {

        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public bool DomainStatus { get; set; }
    }
}
