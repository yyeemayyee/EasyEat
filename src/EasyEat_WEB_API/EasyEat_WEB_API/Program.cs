using Infrastructure;
using Infrastructure.Abstractions;
using Infrastructure.Ripository;
using Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string origin = "MyAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserinfoRepository, UserinfoRepository>();
builder.Services.AddScoped<IDbCreator, DbCreator>();
builder.Services.AddDbContext<DataContext>(options =>
   options.UseSqlServer(
       "Server=localhost,1433;Database=EasyEat;user id=graphservice1datareader;password='graphservice1datareader';Trust Server Certificate=true"));
     //"Server=localhost,1433;Database=EasyEat;user id=sa;password='123';Trust Server Certificate=true"));


builder.Services.AddCors(o => o.AddPolicy(origin, builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    
    var dbCreator = services.GetService<IDbCreator>();
    dbCreator?.Create();
}

app.Run();