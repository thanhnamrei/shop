using Data;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Queries;

public class GetProductDetailQuery : IRequest<Product?>
{
	public int Id { get; set; }
}

public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, Product?>
{
	private readonly AppDbContext _context;

	public GetProductDetailQueryHandler(AppDbContext context)
	{
		_context = context;
	}

	public async Task<Product?> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
	{
		var product = await _context.Products
			.Include(p => p.ProductReviews)
			.FirstOrDefaultAsync(p => p.Id == request.Id);

		return product;
	}
}