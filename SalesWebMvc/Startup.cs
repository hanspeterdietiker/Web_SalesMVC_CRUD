using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SalesWebMvcContext>
(options => options.UseSqlServer(
    "Data Source=DESKTOP-T6KTKSE\\HANSPETER;Initial Catalog=Web_SalesMVC_CRUD;User ID=Hanspeter;Password=123456"));


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();

builder.Services.AddScoped<SellerService>();

builder.Services.AddScoped<DepartmentService>();

var app = builder.Build();
var enUs = new CultureInfo("en-Us");
var localizationOption = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUs),
    SupportedCultures = new List<CultureInfo> { enUs },
    SupportedUICultures = new List<CultureInfo> { enUs }
};

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseRequestLocalization(localizationOption);


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();