using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Services;

public interface IProductReviewService
{
    Task AddReview(ProductReview productReview);

    Task<List<ProductReview>> GetProductReviews(int productId);
}

public class ProductReviewService : IProductReviewService
{
    private readonly AppDbContext _context;

    public ProductReviewService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ProductReview>> GetProductReviews(int productId)
    {
        var query = _context.ProductReviews.AsQueryable();
        query.Where(x => x.ProductId == productId);

        return await query.ToListAsync();
    }

    public async Task AddReview(ProductReview productReview)
    {
        _context.ProductReviews.Add(productReview);

        await _context.SaveChangesAsync();
    }
}