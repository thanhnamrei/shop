﻿using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductsQuery

{
	public class Query : IRequest<List<Product>>
	{
		public int CategoryId { get; set; }
	}

	public class Handler : IRequestHandler<Query, List<Product>>
	{
		private readonly IProductService _productService;

		public Handler(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
		{
			var products = await _productService.GetProductsAsync(request.CategoryId);

			return products;
		}
	}
}