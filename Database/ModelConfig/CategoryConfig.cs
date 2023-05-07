using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.ModelConfig {
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
			builder.ToTable("Category");
            builder.HasKey(u => u.CategoryId);

            builder.Property(u => u.Name).HasMaxLength(200);
        }
    }
}