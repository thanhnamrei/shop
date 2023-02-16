using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);
//var configuration = builder.Configuration;
//var services = builder.Services;

//// Add services to the container.
//var connectionString = configuration.GetConnectionString("NorthwindConnection");
//services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//services.AddProductAPIServices();

//services.AddCors(options =>
//{
//    options.AddDefaultPolicy(policy =>
//    {
//        policy.WithOrigins("*");
//    });
//});

//services.AddControllers();

//services.AddEndpointsApiExplorer();
//services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseCors();

//app.UseAuthorization();

//app.MapControllers();

builder.Services.AddRateLimiter(_ => _
    .AddFixedWindowLimiter(policyName: "fixed", options =>
    {
        options.PermitLimit = 4;
        options.Window = TimeSpan.FromSeconds(12);
        options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        options.QueueLimit = 2;
    }));

var app = builder.Build();

app.UseRateLimiter();

static string GetTicks() => (DateTime.Now.Ticks & 0x11111).ToString("00000");

app.MapGet("/", () => Results.Ok($"Hello {GetTicks()}"))
    .RequireRateLimiting("fixed");

app.Run();
