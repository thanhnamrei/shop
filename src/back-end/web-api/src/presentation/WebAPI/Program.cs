using System.Reflection;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProductAPI;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var services = builder.Services;

// Add services to the container.
var connectionString = configuration.GetConnectionString("NorthwindConnection");
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

services.AddProductAPIServices();

services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("*");
    });
});

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

app.UseAuthorization();

app.MapControllers();

app.Run();
