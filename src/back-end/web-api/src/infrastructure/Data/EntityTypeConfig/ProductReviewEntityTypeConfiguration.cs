using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityTypeConfig;
internal class ProductReviewEntityTypeConfiguration : IEntityTypeConfiguration<ProductReview>
{
    public void Configure(EntityTypeBuilder<ProductReview> builder)
    {
        builder
            .ToTable("ProductReview", schema: "Production")
            .HasKey(nameof(ProductReview.ProductId), nameof(ProductReview.EmailAddress));
    }
}
