//using Nerwork.
//using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

string conStr = builder.Configuration.GetConnectionString("DefaultConecction");

builder.Services.AddDbContext(conStr);

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


app.Run("http://localhost:32587");
//app.MapGet("/", () => "Hello World!");
