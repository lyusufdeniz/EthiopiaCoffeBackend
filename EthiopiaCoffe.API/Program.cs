using EthiopiaCoffe.API.Extensions;
using EthiopiaCoffe.API.Filters;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//suppres .net core builtin validation filter response
builder.Services.Configure<ApiBehaviorOptions>(x => { x.SuppressModelStateInvalidFilter = true; });

builder.Services.InjectEFCoreForSqlServer(builder.Configuration);
builder.Services.InjectRepositories();
builder.Services.InjectServices();





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
