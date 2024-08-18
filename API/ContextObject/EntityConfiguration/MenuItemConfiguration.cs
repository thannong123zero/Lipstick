using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedLibrary.DTO;

namespace API.ContextObject.EntityConfiguration
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.HasOne<MenuGroup>(s => s.MenuGroup).WithMany(g => g.MenuItems).HasForeignKey(s => s.MenuGroupID).IsRequired();
        }
    }
}
