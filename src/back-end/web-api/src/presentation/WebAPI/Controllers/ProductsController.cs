using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductAPI;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
public class ProductsController : Controller
{
    // private readonly  mediator
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator) => _mediator = mediator;


    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new ListHandler.Query());
        return Ok(products);
    }
}

