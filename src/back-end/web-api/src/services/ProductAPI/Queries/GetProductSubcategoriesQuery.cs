using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductSubcategoriesQuery : IRequest<List<ProductSubcategory>>
{
}

public class GetProductSubcategoriesQueryHandler : IRequestHandler<GetProductSubcategoriesQuery, List<ProductSubcategory>>
{
	private readonly IProductService _productService;

	public GetProductSubcategoriesQueryHandler(IProductService productService)
	{
		_productService = productService;
	}

	public async Task<List<ProductSubcategory>> Handle(GetProductSubcategoriesQuery request, CancellationToken cancellationToken)
	{
		return await _productService.GetProductSubcategories();
	}
}