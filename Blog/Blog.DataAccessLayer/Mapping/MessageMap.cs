using Blog.EntitesLayer.Concrate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.DataAccessLayer.Mapping
{
    public class MessageMap:EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            this.Property(x => x.MessageId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.MessageContent).HasColumnType("nvarchar").HasMaxLength(4000);
            this.Property(x => x.MessageSubject).HasColumnType("nvarchar").HasMaxLength(200);
   
        }
    }
}
