using api.Interfaces;
using api.Models;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DBConnection dbConnection = builder.Configuration.GetSection("DBConnection").Get<DBConnection>();
var connectionString = $"server={dbConnection.Server};user={dbConnection.User};password={dbConnection.Password};database={dbConnection.Database};TrustServerCertificate=True";
builder.Services.AddDbContext<alspecContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddScoped<IJobService, JobService>();

var allowedOrigins = builder.Configuration.GetSection("CORS-Settings:Allow-Origins").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAlspecApp",
        builder => builder.WithOrigins(allowedOrigins)
        .AllowAnyMethod()
        .AllowAnyHeader());
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("AllowAlspecApp");

app.UseRouting();

app.MapControllers();

app.Run();