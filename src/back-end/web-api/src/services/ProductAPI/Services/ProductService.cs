using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Services;

public interface IProductService
{
    Task<Product> GetProductById(int id);

    Task<List<Product>> GetProductsAsync();

    Task<List<ProductSubcategory>> GetProductSubcategories();
}

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products
            .Include(p => p.ProductSubcategory)
            .Include(p => p.ProductReviews)
            .ToListAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        var product = await _context.Products
            .Include(p => p.ProductReviews.Take(2))
            .FirstOrDefaultAsync(p => p.Id == id);

        return product ?? new Product();
    }

    public async Task<List<ProductSubcategory>> GetProductSubcategories()
    {
        return await _context.ProductsSubcategories.ToListAsync();
    }
}