using KYS.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class DashboardController : Controller
{
   

    public IActionResult Index()
    {       
        return View();
    }

    public IActionResult AracBilgi()
    {
        return View();
    }

   
} 