using Clients.Services.Data;
using Clients.Services.Data.EFCore;
using Clients.Services.Services;
using Clients.Services.Services.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<IClientDao, ClientDao>();

var connectionString = builder.Configuration.GetConnectionString("ClientDatabase");
builder.Services.AddDbContext<ClientsContext>(options => options.UseSqlServer(connectionString));


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
