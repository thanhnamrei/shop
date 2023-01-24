using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Services;

namespace ProductAPI
{
	public static class DependenceInjection
	{
		public static IServiceCollection AddProductAPIServices(this IServiceCollection services)
		{
			services.AddScoped<IProductService, ProductService>();
			services.AddMediatR(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}

