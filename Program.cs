using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Web_Api_Project;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer("name = DefaultConnection"));

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
