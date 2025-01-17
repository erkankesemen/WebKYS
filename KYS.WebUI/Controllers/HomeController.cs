using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KYS.WebUI.Controllers
{
      [Authorize]
    public class HomeController : Controller
    {
        private readonly IAracBilgiService _aracBilgiService;
        public HomeController(IAracBilgiService aracBilgiService)
        {
            _aracBilgiService = aracBilgiService;
        }
        public IActionResult Index()
        {
           

            var model = _aracBilgiService.GetAll();
            if (model == null)
            {
                ViewBag.ErrorMessage = "Veri bulunamadı.";
                return View();
            }

            return View(model);

        }
    }
}