using Application;
using Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ProductAPI;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var services = builder.Services;

// connect db
var connectionString = configuration.GetConnectionString("SqlServerConnection");
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Add FluentValidation
services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// Add services to the container
services.AddProductApiServices();
services.AddApplication();


services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy.WithOrigins("*"));
});

services.AddResponseCaching();
services.AddSignalR();

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = configuration.GetConnectionString("RedisConnection");
    options.InstanceName = "REI_";
});

services.AddOutputCache(options =>
{
    options.AddBasePolicy(build => build.Cache());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors();

//
//app.UseResponseCaching();

//app.Use(async (context, next) =>
//{
//    context.Response.GetTypedHeaders().CacheControl = new CacheControlHeaderValue()
//    {
//        Public = true,
//        MaxAge = TimeSpan.FromSeconds(10)
//    };

//    context.Response.Headers[HeaderNames.Vary] = new string[] { "Accept-Encoding" };

//    await next();
//});


app.UseAuthorization();

app.MapControllers();

app.Run();