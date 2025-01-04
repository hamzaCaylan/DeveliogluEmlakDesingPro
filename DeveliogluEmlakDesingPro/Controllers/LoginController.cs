using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Yonetici p)
        {
            Emlak c= new Emlak();
            //var datavalue= c.Yoneticis.FirstOrDefault(x=>x.Yone)
            return View();
        }
    }
}
