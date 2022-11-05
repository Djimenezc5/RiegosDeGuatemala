using Microsoft.EntityFrameworkCore;
using RiegosDeGuatemala;

var builder = WebApplication.CreateBuilder(args);
var _MyCors = "_MyCors";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Obtenemos el Connection String de appsettings.Development.json
var conntecionString = builder.Configuration.GetConnectionString("DefaultConnection");
//Implementamos el Connection String con el DBContext 
builder.Services.AddDbContext<RGContext>(opciones => opciones.UseSqlServer(conntecionString));
//Implementacion de Cors -> politicas de uso de apis
builder.Services.AddCors(options => 
{
    options.AddPolicy(name: _MyCors, builder =>
    {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(_MyCors);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
