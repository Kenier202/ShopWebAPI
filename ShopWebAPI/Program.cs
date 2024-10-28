using Microsoft.EntityFrameworkCore;
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


builder.Services.AddControllers();
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
