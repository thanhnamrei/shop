using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using ProductAPI.Queries;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
public class ProductsController : Controller
{
    // private readonly  mediator
    private readonly IMediator _mediator;
    private readonly IDistributedCache _cache;

    public ProductsController(IMediator mediator, IDistributedCache cache)
    {
        _mediator = mediator;
        _cache = cache;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new ProductsList.Query());
        return Ok(products);
    }

    [HttpGet("Categories")]
    public async Task<IActionResult> GetProductSubcategories()
    {
        var categories = await _mediator.Send(new ProductSubcategoriesList.Query());

        return Ok(categories);
    }

}
