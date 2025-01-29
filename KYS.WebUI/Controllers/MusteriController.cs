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
    public class MusteriController : Controller
    {
        private readonly IMusteriService _musteriService;
        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }
        
        public IActionResult Index()
        {
            var viewModel = new AracBilgiViewModel
            {
                Musteriler = _musteriService.GetAll()
            };
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult CreateMusteri()
        {
            return View("");
        }
        [HttpPost]
        public IActionResult CreateMusteri(Musteri musteri)
        {
            var entity = new Musteri()
            {
                MusteriAdi = musteri.MusteriAdi,
                MusteriAdresi = musteri.MusteriAdresi,
                Tel = musteri.Tel,
                CepTel = musteri.CepTel,
                FirmaId = 8
            };
            _musteriService.Add(entity);
            return RedirectToAction("Index");

        }
        
        

    }
}