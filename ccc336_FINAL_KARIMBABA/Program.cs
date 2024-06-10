using ccc336_FINAL_KARIMBABA.Extensions;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ccc336_FINAL_KARIMBABA.Extenstions;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddAutoMapperConfig();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.GlobalExceptions();
builder.Services.addDb(builder.Configuration);
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
