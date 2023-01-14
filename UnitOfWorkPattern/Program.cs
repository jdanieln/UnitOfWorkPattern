using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UnitOfWorkPattern.Configuration;
using UnitOfWorkPattern.Data;
using UnitOfWorkPattern.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UnitOfWorkPatternContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UnitOfWorkPatternContext") ?? throw new InvalidOperationException("Connection string 'UnitOfWorkPatternContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
