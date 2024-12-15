using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
	public class denemeController1 : Controller
	{
		EmlakManager em = new EmlakManager(new EfEmlakRepository());

		public IActionResult Index()
		{
			var values =em.GetListWithEmlakTips();
			return View(values);
		}
	}
}
