using Employee_Main.Data;
using Employee_Main.Repository;
using Employee_Main.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200") // Your Angular app URL
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// add scoped means that there will be a new instance for every http request 
// we have transaint and singleton too but because the dbcontext creates an new instance for every operation therefore we use this
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>(); //Whenever something (like a controller) asks for IEmployeeService, give it an instance of EmployeeService, and do this in a scoped way.
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
// if we do not add this then i get an error call of 500
var app = builder.Build();
app.UseCors("AllowAngular");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
