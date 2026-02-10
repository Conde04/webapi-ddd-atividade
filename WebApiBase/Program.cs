using WebApiBase.Extensions;
using WebApiBase.Infraestrutura.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
IoCRegister.RegisterModules(services);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureDatabase();
builder.Services.RegisterModules();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
