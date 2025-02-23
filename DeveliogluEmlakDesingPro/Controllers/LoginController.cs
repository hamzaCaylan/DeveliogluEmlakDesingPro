using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]        

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task< IActionResult> Index(Yonetici p)
        {
            
            //48.ders                    
            Context c = new Context();
            var datavalue = c.Yoneticis.FirstOrDefault(x =>x.YoneticiMail == p.YoneticiMail && x.YoneticiSifre == p.YoneticiSifre);
            if(datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.YoneticiMail!)
                };
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal =new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            else {
                return View(); 
            }
        }
    }
}
//46.ders sonrasi 47 de ise login sonrasi satyfa gorunurlugu yapiyor
/*
  var datavalue = c.Yoneticis.FirstOrDefault(x =>x.YoneticiMail == p.YoneticiMail && x.YoneticiSifre == p.YoneticiSifre);
            if(datavalue != null)
            {                
                HttpContext.Session.SetString("username", p.YoneticiMail);
                return RedirectToAction("Index", "Home");
            }
            else {
                return View(); 
            }*/