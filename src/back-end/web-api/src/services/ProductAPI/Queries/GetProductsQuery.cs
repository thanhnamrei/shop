using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductsQuery : IRequest<List<Product>>
{
	public int CategoryId { get; set; }
}

public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
	private readonly IProductService _productService;

	public GetProductsHandler(IProductService productService)
	{
		_productService = productService;
	}

	public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
	{
		var products = await _productService.GetProductsAsync(request.CategoryId);

		return products;
	}
}