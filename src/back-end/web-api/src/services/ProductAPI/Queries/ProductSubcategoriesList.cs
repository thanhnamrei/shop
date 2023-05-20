using Domain.Entities;
using MediatR;
using ProductAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Queries;

public class ProductSubcategoriesList
{
    public class Query : IRequest<List<ProductSubcategory>>
    { }

    public class Handler : IRequestHandler<Query, List<ProductSubcategory>>
    {
        private readonly IProductService _productService;

        public Handler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<ProductSubcategory>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductSubcategories();
        }
    }
}