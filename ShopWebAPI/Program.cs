using Microsoft.EntityFrameworkCore;
using ShopWebAPI.Interfaces;
using ShopWebAPI.Models;
using ShopWebAPI.Repositories;
using ShopWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ProductsContext>(
    c => { c.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnection"));
});

//RepositoryProducts
builder.Services.AddScoped<IProductsRepository<Products>,RepositoryProducts>();

//RepositoryProducsService
builder.Services.AddScoped<IProductsService,ProductsService>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
 
    options.JsonSerializerOptions.ReferenceHandler = null;
    options.JsonSerializerOptions.MaxDepth = 64; 
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
