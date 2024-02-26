using Microsoft.EntityFrameworkCore;
using netan.Persistence;
using AutoMapper;
using netan.Mapping;

var builder = WebApplication.CreateBuilder(args);
 

// Add services to the container.

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// 
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<NetanDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);  
 
//
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();


app.UseCors(options => {
    options
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();   
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
