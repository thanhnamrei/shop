using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductsQuery : IRequest<List<Product>>
{
    public int Limit { get; set; } = 10;
    public int Offset { get; set; } = 0;
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
        var products = await _productService.GetProductsAsync();

        return products;
    }
}