using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 
using Trommeregaard.API.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TrommeregaardAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TrommeregaardAPIContext") ?? throw new InvalidOperationException("Connection string 'TrommeregaardAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<Trommeregaard.API.Service.ICowService, Trommeregaard.API.Service.CowService>();

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
