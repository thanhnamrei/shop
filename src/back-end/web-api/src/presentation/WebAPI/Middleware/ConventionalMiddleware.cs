using Data;

namespace WebAPI.Middleware;

public class ConventionalMiddleware
{
    private readonly RequestDelegate _next;

    public ConventionalMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context, AppDbContext dbContext)
    {
        var keyValue = context.Request.Query["key"];

        if (string.IsNullOrEmpty(keyValue))
        {
            // TO DO
        }

        await _next(context);
    }
}


public class FactoryActivatedMiddleware : IMiddleware
{
    private readonly AppDbContext _appDbContext;

    public FactoryActivatedMiddleware(AppDbContext appDbContext) => _appDbContext = appDbContext;


    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        // TO DO
        await next(context);
    }
}
