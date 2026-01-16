using Microsoft.EntityFrameworkCore;
using SimpleCompany.Context;
using SimpleCompany.Context.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SimpleCompanyContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("SimpleCompany")));

builder.Services.AddScoped<SimpleCompanyContext, SimpleCompanyContext>();
builder.Services.AddScoped<CustomerServices, CustomerServices>();
builder.Services.AddScoped<EmployeeServices, EmployeeServices>();
builder.Services.AddScoped<ProductServices, ProductServices>();
builder.Services.AddScoped<ProductLineServices, ProductLineServices>();
builder.Services.AddScoped<OfficeServices, OfficeServices>();
builder.Services.AddScoped<OrderServices, OrderServices>();
builder.Services.AddScoped<PaymentServices, PaymentServices>();


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
