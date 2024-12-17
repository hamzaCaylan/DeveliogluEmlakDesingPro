using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DeveliogluEmlakDesingPro.Controllers
{
	public class DetayController :  Controller
	{
		EmlakManager em = new EmlakManager(new EfEmlakRepository());

		public IActionResult IlanDetaylari(int id)
		{
			var values = em.GetListWithEmlakTips(id);
			return View(values);
		}
	}
}
