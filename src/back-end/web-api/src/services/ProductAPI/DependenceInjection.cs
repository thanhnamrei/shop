using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Services;
using System.Reflection;

namespace ProductAPI;

public static class DependenceInjection
{
	public static IServiceCollection AddProductApiServices(this IServiceCollection services)
	{
		services.AddScoped<IProductService, ProductService>();
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

		return services;
	}
}