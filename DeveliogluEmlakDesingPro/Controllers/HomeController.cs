using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DeveliogluEmlakDesingPro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeveliogluEmlakDesingPro.Controllers
{
	public class HomeController : Controller
    {
        EmlakManager em = new EmlakManager(new EfEmlakRepository());

        public IActionResult Index()
        {
            var values = em.GetListWithEmlakTips();
            return View(values);
        }
    }
}
