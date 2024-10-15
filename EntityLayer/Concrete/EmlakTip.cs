using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class EmlakTip
	{
		[Key]
		public int EmlakTipID { get; set; }	

		public string EmlakTipName { get; set; }

		public List<Emlak> Emlaks { get; set; }

	}
}
