using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Abstract;

namespace Blog.EntitesLayer.Concrate
{
    /// <summary>
    /// Abone Bülteni
    /// </summary>
    public class Subscripe:IEntity
    {
        [Key]
        public int SubscripeId { get; set; }
        /// <summary>
        /// Abone bülteni email
        /// </summary>
        public string Email { get; set; }
    }
}
