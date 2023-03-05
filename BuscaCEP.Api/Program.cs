using BuscaCEP.Data.Mapping;
using BuscaCEP.Data.Rest;
using BuscaCEP.Service.Interfaces;
using BuscaCEP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EnderecoService, EnderecoService>();builder.Services.AddScoped<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper (typeof(EnderecoMapping));

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
