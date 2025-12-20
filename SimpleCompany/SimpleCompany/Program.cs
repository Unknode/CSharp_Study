using Microsoft.EntityFrameworkCore;
using SimpleCompany.Context;
using SimpleCompany.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SimpleCompanyContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("SimpleCompany")));

builder.Services.AddScoped<SimpleCompanyContext, SimpleCompanyContext>();
builder.Services.AddScoped<CustomerServices, CustomerServices>();

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
