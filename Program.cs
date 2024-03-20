using Gendar.Context;
using Gendar.Mapper;
using Gendar.Repository;
using Gendar.Repository.Inteface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SqlServerContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionString")));

builder.Services.AddScoped<IGendarRepository, GendarRepository>();
builder.Services.AddAutoMapper(typeof(StaffMapper));
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
