using Domain.Entities;
using MediatR;
using ProductAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Queries;

public class ProductsList
{
    public class Query : IRequest<List<Product>>
    { }

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