using Application.MyShop.Interfaces;
using Application.MyShop.Service;
using Infrastructure.MyShop.Contexts;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext <MyShopContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyShop")));
builder.Services.AddTransient(typeof(ICustomerServices), typeof(CustomerSevices));
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
