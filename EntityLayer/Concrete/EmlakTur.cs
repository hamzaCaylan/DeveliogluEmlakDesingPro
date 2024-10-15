using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class EmlakTur
	{
		[Key]
		public int EmlakTurID {  get; set; }

		public string EmlakTurName { get; set; }

		public List<Emlak> Emlaks { get; set; }
	}
}
