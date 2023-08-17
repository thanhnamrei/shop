using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductsQuery : IRequest<List<Product>>
{
    public int CategoryId { get; set; }
}

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
    private readonly IProductService _productService;

    public GetProductsQueryHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = new List<Product>();
        //await _productService.GetProductsAsync(request.CategoryId);

        //if (products.Any())
        //{
        var first = products.FirstOrDefault(x => x.Size == "S", new Product());
        Console.WriteLine(first.Color);
        //}

        return products;
    }
}