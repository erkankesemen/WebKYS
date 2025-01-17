using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KYS.Data.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using KYS.WebUI.Identity;
using KYS.WebUI.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using KYS.Business.Abstract;

namespace KYS.WebUI.Controllers
{


   [AutoValidateAntiforgeryToken]
    public class LoginController :Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public LoginController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager=userManager;
            _signInManager=signInManager;
        }
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {   
                return View(model);
            }

            // var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user==null)
            {
                ModelState.AddModelError("","Bu kullanıcı adı ile daha önce hesap oluşturulmamış");
                return View(model);
            } 

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("","Lütfen email hesabınıza gelen link ile üyeliğinizi onaylayınız.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user,model.Password,true,false);

            if(result.Succeeded) 
            {
                return Redirect(model.ReturnUrl??"~/");
            }

            ModelState.AddModelError("","Girilen kullanıcı adı veya parola yanlış");
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Kullanıcı oluşturma
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            try
            {
                // Kullanıcı oluşturma işlemi
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // Email doğrulama için token oluştur
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = token
                    }, Request.Scheme);

                    // Log veya e-posta işlemleri buraya eklenebilir
                    Console.WriteLine($"Email doğrulama bağlantısı: {confirmationLink}");

                    return RedirectToAction("Login", "Login");
                }

                // Kullanıcı oluşturulamadıysa hataları kullanıcıya göster
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            catch (Exception ex)
            {
                // Beklenmedik hata durumları için loglama
                Console.WriteLine($"Hata: {ex.Message}");
                Console.WriteLine($"Detay: {ex.StackTrace}");
                ModelState.AddModelError("", "Bir hata oluştu, lütfen daha sonra tekrar deneyiniz.");
            }

            return View(model);
        }

    }
}