using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class ListController : Controller
    {
        EmlakManager em = new EmlakManager(new EfEmlakRepository());

        public IActionResult Ilanlar()
        {
            var values = em.GetListWithEmlakTips();
            return View(values);
        }
    }
}
