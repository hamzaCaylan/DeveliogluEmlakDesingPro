using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class YoneiciCotroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Test()
        {
            return View();
        }
    }
}
