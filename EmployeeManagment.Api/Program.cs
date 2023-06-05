using EmployeeManagment.Api.BussinesLayout.Data;
using EmployeeManagment.Api.BussinesLayout.Interfaces;
using EmployeeManagment.Api.BussinesLayout.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


//var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
//var environmentName = builder.Environment.EnvironmentName;

//builder.Configuration
//    .SetBasePath(currentDirectory)//check if this is necessary
//    .AddUserSecrets<Program>()
//    .AddEnvironmentVariables();


// Add services to the container.
builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentService>();

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
