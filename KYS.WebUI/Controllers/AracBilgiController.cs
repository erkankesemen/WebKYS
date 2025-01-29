using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using KYS.Entity;
using KYS.Entity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KYS.WebUI.Controllers
{
    [Authorize]
    public class AracBilgiController : Controller
    {
        private readonly IAracBilgiService _aracBilgiService;
        private readonly IMusteriService _musteriService;
        public AracBilgiController(IAracBilgiService aracBilgiService, IMusteriService musteriService)
        {
            _aracBilgiService = aracBilgiService;
            _musteriService = musteriService;
        }
        public IActionResult Index()
        {
            var viewModel = new AracBilgiViewModel
            {
                AracBilgileri = _aracBilgiService.GetAll(),
                Musteriler = _musteriService.GetAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(AracBilgi aracBilgi)
        {
            try
            {
                // Form'dan gelen musteriId hidden field'dan alınacak
                // int musteriId = int.Parse(Request.Form["musteriId"]);
                // aracBilgi.MusteriId = musteriId;
                
                _aracBilgiService.Add(aracBilgi);
                return Json(new { success = true, message = "Kayıt başarıyla eklendi." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        public IActionResult GetFirma(int Id)
        {
            var firma = _musteriService.GetById(Id);
            return Json(firma);
        }
    }
}