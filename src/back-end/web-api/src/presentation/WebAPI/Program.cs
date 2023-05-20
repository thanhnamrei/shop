using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ProductAPI;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var services = builder.Services;

// connect db
var connectionString = configuration.GetConnectionString("SqlServerConnection");
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Add services to the container
services.AddProductAPIServices();

services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("*");
    });
});

services.AddResponseCaching();

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

//
app.UseResponseCaching();

app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl = new CacheControlHeaderValue()
    {
        Public = true,
        MaxAge = TimeSpan.FromSeconds(10)
    };

    context.Response.Headers[HeaderNames.Vary] = new string[] { "Accept-Encoding" };

    await next();
});

app.UseAuthorization();

app.MapControllers();


app.Run();
