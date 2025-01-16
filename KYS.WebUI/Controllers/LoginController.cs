using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KYS.Data.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using KYS.WebUI.Identity;
using KYS.WebUI.Models;

namespace KYS.WebUI.Controllers
{


    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly NetContext _context;
        private UserManager<User> _userManager;
        private SignInManager<User> _signManager;
        public LoginController(UserManager<User> userManager, SignInManager<User> signManager, NetContext context)
        {
            _userManager = userManager;
            _signManager = signManager;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }




        /*  [HttpPost]
         public async Task<IActionResult> Login(int firmaKodu, string username, string password, bool remember = false, string returnUrl = null)
         {
             if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
             {
                 ModelState.AddModelError("", "Kullanıcı adı ve şifre boş olamaz");
                 return View(); // Hata mesajı göster ve aynı sayfaya geri dön
             }

             var user = _context.Personeller.FirstOrDefault(p =>
                 p.FirmaKodu == firmaKodu &&
                 p.KullaniciAdi == username &&
                 p.Sifre == password);

             if (user == null)
             {
                 ModelState.AddModelError("", "Bu kullanıcı veri tabanında bulunamadı");
                 return View(); // Kullanıcı bulunamazsa, hata mesajı göster ve formu geri gönder
             }

             var signInResult = await _signManager.PasswordSignInAsync(username, password, remember, false);

             if (signInResult.Succeeded)
             {
                 Console.WriteLine($"Giriş başarılı: {username}");

                 // ReturnUrl varsa, o sayfaya yönlendir
                 if (Url.IsLocalUrl(returnUrl))
                 {
                     return Redirect(returnUrl); // ReturnUrl geçerli bir URL ise o sayfaya yönlendir
                 }

                 // ReturnUrl yoksa, ana sayfaya yönlendir
                 return RedirectToAction("Index", "Home");
             }
             else
             {
                 ModelState.AddModelError("", "Geçersiz giriş.");
                 return View(); // Giriş başarısızsa hata göster
             }
         }
  */
 [HttpPost]
    public async Task<IActionResult> Login(int firmaKodu ,string username, string password, string returnUrl = null)
    {
        // Kullanıcıyı veritabanında kontrol et
        var user = _context.Personeller.FirstOrDefault(u => u.FirmaKodu == firmaKodu &&  u.KullaniciAdi == username && u.Sifre == password);
        
        if (user != null)
        {
            // Kullanıcı doğrulandı, ClaimsIdentity oluştur
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                // Diğer claim'ler eklenebilir
            };
            
            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            // Çerez ile giriş yap
            await HttpContext.SignInAsync("Cookies", claimsPrincipal);

            // ReturnUrl varsa o sayfaya yönlendir, yoksa ana sayfaya yönlendir
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        
        // Geçersiz giriş
        ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre";
        return View();
    }



    }
}
