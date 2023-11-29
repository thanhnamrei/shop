using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Commands;
using ProductAPI.Services;
using System.Reflection;

namespace ProductAPI;

public static class DependenceInjection
{
    public static IServiceCollection AddProductApiServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductReviewService, ProductReviewService>();
        services.AddTransient<IValidator<CreateProductReviewCommand>, CreateProductReviewCommandValidator>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}