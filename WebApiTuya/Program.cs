using TestTuya.Domain.Service;
using TestTuya.Domain.Service.Interface;
using TestTuya.Domain.Service.IRepository;
using TestTuya.Domain.Service.Repository;
using TestTuya.Infraestructure.Recursos;
using TestTuya.ServicioLogistica.Adapter;
using TestTuya.ServicioLogistica.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IConvertDataTable, ConvertDataTable>();
builder.Services.AddScoped<IFacturasService, FacturasService>();
builder.Services.AddScoped<IFacturasRepository, FacturasRepository>();
builder.Services.AddScoped<ILogisticaService, LogisticaService>();
builder.Services.AddScoped<ILogisticaAdapter, LogisticaAdapter>();
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
