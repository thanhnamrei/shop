using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using ProductAPI.Commands;
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
	public async Task<IActionResult> GetProducts(GetProductsQuery query)
	{
		var products = await _mediator.Send(query);
		return Ok(products);
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetProducts(int id)
	{
		var product = await _mediator.Send(new GetProductDetailQuery { Id = id });
		return Ok(product);
	}

	[HttpGet("Categories")]
	public async Task<IActionResult> GetProductSubcategories()
	{
		var categories = await _mediator.Send(new GetProductSubcategoriesQuery());

		return Ok(categories);
	}

	[HttpPost("ProductReviews")]
	public async Task<IActionResult> CreateProductReview(CreateProductReviewCommand command) => Ok(await _mediator.Send(command));
}