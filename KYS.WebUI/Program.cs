using KYS.Business.Abstract;
using KYS.Business.Concrete;
using KYS.Data.Abstract;
using KYS.Data.Concrete;
using KYS.Data.Concrete.EfCore;
using KYS.WebUI.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NetContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NetContext"));
});

builder.Services.AddDbContext<ApplicationContext>(options=>options.UseSqlServer("ApplicationContext"));
builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options=> {
    options.Password.RequireDigit = true; // mutlaka sayısal değer girecek
   /*  options.Password.RequireLowercase = true; //mutlaka küçük harf olmalı
    options.Password.RequireUppercase = true; // büyük harf olmalı
    options.Password.RequiredLength = 6; // minimum karakter sayısı */

    options.Lockout.MaxFailedAccessAttempts = 5; // maksimum 5 hata yapabilir ve block edilir hesap
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);// 5 dk bloklar
    options.User.RequireUniqueEmail = true; //aynı mail ile sadece 1 tane kullanıcı olmalı

    
});
builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = "/Login/Login";
    options.LogoutPath = "/Login/Login";
    options.AccessDeniedPath ="/Login/AccessDenied";
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = ".KYS.Web.Cookie"
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAracBilgiService, AracBilgiManager>();
builder.Services.AddScoped<ILoginService, LoginBilgiManager>();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}); 

builder.Services.AddAuthentication("CookieAuthentication")
    .AddCookie("CookieAuthentication", options =>
    {
        options.LoginPath = "/Login/Login";
        options.AccessDeniedPath = "/Login/AccessDenied";
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession(); 
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
