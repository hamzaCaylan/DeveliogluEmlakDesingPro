
using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace DeveliogluEmlakDesingPro.ViewConponent
{
	public class EmlakList: ViewComponent
	{
        EmlakManager em = new EmlakManager(new EfEmlakRepository());

		public IViewComponentResult Invoke()
		{
			var values = em.GetListWithEmlakTips(11);
			return View();
		}
	}
}
