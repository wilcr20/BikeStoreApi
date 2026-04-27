using BikeStoreApi.Data;
using BikeStoreApi.Models;
using BikeStoreApi.Repositories.Production;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("DBConnection");


builder.Services.AddDbContext<DBContextSqlServer>(options => 
        options.UseSqlServer(connectionString));

builder.Services.AddTransient<IProductionRepository, ProductionRepository>();


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


/*
 * --- Strucure for the projects

Entities/         # Contains models representing database entities, with properties directly mapped to table columns.
Data/             # Contains the `AppDbContext`, which is your gateway to the database.
Dtos/             # Defines Data Transfer Objects (DTO's) for request and response handling, ensuring data encapsulation and structured communication.
Repositories/     # Implements data access logic, effectively separating it from core business operations.
Program.cs        # Application startup and configuration
 */

/*
 
Command used to genrate classes from existing DB
Scaffold - DbContext "Server=.;Database=BikeStores;Integrated Security=True;Encrypt=False;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
*/

