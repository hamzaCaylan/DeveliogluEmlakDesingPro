using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class RegisterController : Controller
    {
        YoneticiManager yn = new YoneticiManager(new EfYoneticiRepository());
        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Register(Yonetici p )
        {
            p.YoneticiUnvan = "Admin";
            yn.YoneticiAdd(p);
            return RedirectToAction("index", "Home");
            //YoneticiValidator wv = new YoneticiValidator();
            //ValidationResult result = wv.Validate(p);
            //if (result.IsValid)
            //{
            //    p.YoneticiUnvan = "Admin";
            //    yn.YoneticiAdd(p);
            //    return RedirectToAction("index", "Home");
            //}else
            //{

            //}
          

        }

    }
}
