using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductAPI;
using ProductAPI.Queries;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
public class ProductsController : Controller
{
    // private readonly  mediator
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator) => _mediator = mediator;

    [HttpGet("")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new ProductsList.Query());
        return Ok(products);
    }

    [HttpGet("Categories")]
    public async Task<IActionResult> GetProductSubcategories()
    {
        var products = await _mediator.Send(new ProductSubcategoriesList.Query());
        return Ok(products);
    }
}