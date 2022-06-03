using LibM.Data.Context;
using LibM.Services.Abstractions;
using LibM.Services.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile($"appsettings.{enviroment}.json", false, true)
                            .Build();
var connectionString = builder.Configuration.GetSection("Settings:Database:ConnectionString").Value;
//var connectionString = builder.Configuration.GetSection("Settings:Database:ConnectionString").Value;
//builder.Services.Configure<Settings>(builder.Configuration.GetSection("Settings")); Ioption için register edebiliriz.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibMDbContext>(builder => //register ettik (DI Container)
{
    builder.UseSqlServer(connectionString);
});
builder.Services.AddDataServices(); //register ettik (DI Container)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
