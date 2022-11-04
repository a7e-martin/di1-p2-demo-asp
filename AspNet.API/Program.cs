using AspNet.DAL;
using AspNet.DAL.Contracts;
using AspNet.Services;
using AspNet.Services.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PokemonDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PokemonDb"));
});

builder.Services.AddScoped<IPokemonService, PokemonService>();
builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();


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

