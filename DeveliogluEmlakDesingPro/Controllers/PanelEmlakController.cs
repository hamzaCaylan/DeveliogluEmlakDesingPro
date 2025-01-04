using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
    public class PanelEmlakController : Controller
    {
        EmlakManager em = new EmlakManager(new EfEmlakRepository());
        [HttpGet]
        public IActionResult PanelEmlakAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PanelEmlakAdd(Emlak e)
        {
            e.EmlakYayinda = "Admin";
            e.BolgeMahalleID = 2;
            e.EmlakTipID = 2;
            e.EmlakTurID = 2;
            e.YoneticiID = 2;
            e.EmlakOtopark = "Yok";
            e.EmlakAsansor = "Yok";
            e.EmlakEsya = "Yok";


            em.EmlakAdd(e);
            return RedirectToAction("index", "Home");

        }
    }
}
