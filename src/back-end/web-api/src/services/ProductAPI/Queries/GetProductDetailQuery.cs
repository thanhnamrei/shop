using Data;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductDetailQuery : IRequest<Product?>
{
    public int Id { get; set; }
}

public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, Product?>
{
    private readonly IProductService _productService;

    public GetProductDetailQueryHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<Product?> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
    {
        return await _productService.GetProductById(request.Id);
    }
}