using Data.EntityTypeConfig;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductSubcategory> ProductsSubcategories => Set<ProductSubcategory>();
    public DbSet<ProductReview> ProductReviews => Set<ProductReview>();



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
        new ProductSubcategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductSubcategory>());
        new ProductReviewEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductReview>());
    }
}