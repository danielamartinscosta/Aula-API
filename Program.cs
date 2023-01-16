using api.Models;
using api.Repositorios.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IServico, ClienteRepositorio>(); //resolver a dependencia //quando eu quiser salvar em memória, será dessa forma
//builder.Services.AddScoped<IServico, ClienteRepositorioMySql>(); //quando eu quiser salvar em mysql será dessa forma
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
