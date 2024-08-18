using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedLibrary.DTO;

namespace API.ContextObject.EntityConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.SubjectEN).IsRequired();
            builder.Property(s => s.SubjectVN).IsRequired();
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            builder.Property(s=> s.ContentEN).IsRequired();
            builder.Property(s=> s.ContentVN).IsRequired();
            builder.Property(s=> s.Avatar).IsRequired();
            builder.HasOne<Topic>(s => s.Topic).WithMany(g => g.Articles).HasForeignKey(s => s.TopicID).IsRequired();
        }
    }
}
