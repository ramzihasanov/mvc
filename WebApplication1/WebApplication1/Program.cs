using Microsoft.EntityFrameworkCore;
using WebApplication1;
using System;
using WebApplication1.DataAccesLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//builder.Services.addDbContext<>

builder.Services.AddDbContext<AppDBContext>(opt => {
    opt.UseSqlServer("Server=DESKTOP-V62NBK6;Database=MVCSlider;Trusted_Connection=True");

});



var app = builder.Build();

app.MapControllerRoute(


    name: "default",
    pattern: "{Controller=home}/{Action=index}/{id?}");

app.UseStaticFiles();

app.Run();
