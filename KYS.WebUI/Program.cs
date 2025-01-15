using KYS.Business.Abstract;
using KYS.Business.Concrete;
using KYS.Data.Abstract;
using KYS.Data.Concrete;
using KYS.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DbContext kayd�
builder.Services.AddDbContext<NetContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NetContext"));
});

// Servis katman� ve UnitOfWork kayd�
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAracBilgiService, AracBilgiManager>();

// Razor Pages ve Controllers yap�land�rmas�
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Static Files i�in yap�land�rma
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
    RequestPath = "/modules"
});

// Routing
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Controller Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "AracEkle",
//    pattern: "AracEkle/{firmaId?}",
//    defaults: new { controller = "AracEkle", action = "AracKayit" });

// Razor Pages Routes
app.MapRazorPages();

app.Run();
