using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedLibrary.DTO;

namespace API.ContextObject.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.NameEN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.NameVN).IsRequired().HasMaxLength(100);
            builder.Property(s => s.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.ModifiedOn).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.InHomePage).HasDefaultValue(false);
            builder.Property(s => s.Price).IsRequired();
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Price).IsRequired();
            builder.HasOne<Unit>(s => s.Unit).WithMany(g => g.Products).HasForeignKey(s => s.UnitID).IsRequired();
            builder.HasOne<MenuItem>(s => s.MenuItem).WithMany(g => g.Products).HasForeignKey(s => s.MenuItemID).IsRequired();
            builder.HasOne<Brand>(s => s.Brand).WithMany(g => g.Products).HasForeignKey(s => s.BrandID).IsRequired(false);
        }
    }
}
