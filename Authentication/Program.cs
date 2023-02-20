using Authentication;
using Authentication.Configurations;
using Authentication.Controllers;
using Authentication.Data;
using Authentication.Models;
using Authentication.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Win32;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

builder.Services.ConfigureIdentity();

builder.Services.AddAutoMapper(typeof(MapperInitilizer));

builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.AddScoped<IAuthManager, AuthManager>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();




app.Run();
