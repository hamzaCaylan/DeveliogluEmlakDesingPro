using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        //54 goruntu olustur oncesinde admin page ekle
        public IActionResult IlanlarByYonetici ()
        {
          var values=  em.GetEmlakListByYoneticiBm(2);
            return View(values);
        }


        public IActionResult IlanAdd()
        {//56.ders
            YoneticiManager yn = new YoneticiManager(new EfYoneticiRepository());
            List<SelectListItem> yonet = (from x in yn.GetList()
                                             select new SelectListItem
                                             {
                                                 Text=x.YoneticiAdi,
                                                 Value=x.YoneticiID.ToString()
                                             }).ToList();
            ViewBag.cv = yonet;
            return View();
        }
        [HttpGet]
        public IActionResult EditByEmlak(int id)
        {
            var emlakValue = em.GetById(id);
            return View(emlakValue);
        }
        [HttpPost]
        public IActionResult EditByEmlak(Emlak p)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
