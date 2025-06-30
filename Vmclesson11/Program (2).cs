using Microsoft.EntityFrameworkCore;
using VmcLesson09.Models;
using VmcLesson09.Modelsss;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext
var connectionString = builder.Configuration.GetConnectionString("VmcBookStore");
builder.Services.AddDbContext<VmcBookStoreContext>(x => x.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/VmcHome/VmcError");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=VmcHome}/{action=VmcIndex}/{Vmcid?}");

app.Run();
