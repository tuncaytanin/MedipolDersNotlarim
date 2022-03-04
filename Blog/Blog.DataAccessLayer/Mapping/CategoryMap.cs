using Blog.EntitesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Mapping
{

    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            
            this.Property(x => x.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.CategoryName).HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
