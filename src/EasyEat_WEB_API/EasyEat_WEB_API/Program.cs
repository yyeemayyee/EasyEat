using Infrastructure;
using Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbCreator, DbCreator>();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        "Server=localhost,1433;Database=EasyEat;user id=graphservice1datareader;password='graphservice1datareader';Trust Server Certificate=true"));

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

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    
    var dbCreator = services.GetService<IDbCreator>();
    dbCreator?.Create();
}

app.Run();