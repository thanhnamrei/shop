using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;

namespace ProductAPI.Services;

public interface IProductService
{
    Task<List<Product>> GetProductsAsync(QueryParams? query);

    Task<List<ProductSubcategory>> GetProductSubcategories();
}

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsAsync(QueryParams? query)
    {
        return await _context.Products
            //.Include(p => p.ProductSubcategory)
            .Include(p => p.ProductReviews)
            //.Where(p => query == null || p.ProductSubcategoryId == query.CategoryId)
            .ToListAsync();
    }

    public async Task<List<ProductSubcategory>> GetProductSubcategories()
    {
        return await _context.ProductsSubcategories.ToListAsync();
    }
}