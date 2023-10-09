using Microsoft.EntityFrameworkCore;
using TemperatureSensor;
using TemperatureSensor.Repository;
using AutoMapper;
using TemperatureSensor.Repository.Interface;
using TemperatureSensor.Services;
using TemperatureSensor.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}
).AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TemperatureInfoContext>(
    DbContextOptions => DbContextOptions.UseSqlite(
        builder.Configuration["ConnectionStrings:TemperatureInfoDBConnectionString"]));

builder.Services.AddScoped<ITemperatureInfoRepository, TemperatureInfoRepository>();
builder.Services.AddScoped<IStateLimitRepository, StateLimitRepository>();
builder.Services.AddScoped<ITemperatureInfoService, TemperatureInfoService>();
builder.Services.AddScoped<IStateLimitService, StateLimitService>();

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
