using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI;

public static class ListHandler
{
    public class Query : IRequest<List<Product>> { }

    public class Handler : IRequestHandler<Query, List<Product>>
    {
        private readonly IProductService _productService;

        public Handler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsAsync();
        }
    }
}
