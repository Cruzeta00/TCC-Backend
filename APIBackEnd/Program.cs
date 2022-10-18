using APIBackEnd.Database;
using APIBackEnd.Modelos;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

using var db = new ModeloDBContext();

db.Add(new ModeloLogin { 
    Nome = "ADMIN",
    Senha = "ADMIN",
    Email = "julio10as@gmail.com"
});
db.SaveChanges();

app.Run();

