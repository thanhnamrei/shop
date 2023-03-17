using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Services;

public interface IProductService
{
    Task<List<Product>> GetProductsAsync();
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
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .ToListAsync();
    }
}
