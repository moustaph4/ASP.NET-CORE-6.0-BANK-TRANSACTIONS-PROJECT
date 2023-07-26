using BankaIslemleriProjesi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext sýnýfý için Dependency Injection yapalým. ----------------------

builder.Services.AddDbContext<IslemDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon")));

// --------------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Islem}/{action=Index}/{id?}");

app.Run();
